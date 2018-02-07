using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Testing_123.Models;

namespace Testing_123.Controllers
{
    public class NumbersController : Controller
    {

        // GET: Numbers
        [HttpGet]
        public ActionResult Index()
        {
            Numberses num = new Numberses();

            ViewBag.test1 = 0;
            ViewBag.test2 = 0;
            ViewBag.test3 = 0;
            ViewBag.test4 = 0;
            ViewBag.test5 = 0;
            ViewBag.time = 0;

            

            return View(num);
        }

        //valkaz, valkon, valmast - уровни казарм, конюшен, мастерских массивом
        //typekaz, typekon, typemast - типы войск обучающихся массивом
        //chackkaz, checkkon - чекбоксы для установки бкбк
        //time, timeNum - количество часов (час/день/неделя...), количество часов указанное в поле
        [HttpPost]
        public ActionResult Index(int[] valkaz, int[] valkon, int[] valmast, 
                                    int[] typekaz, int[] typekon, int[] typemast,
                                    bool[] checkkaz, bool[] checkkon,
                                    int time, int servertype = 1, int timeNum = 1)
        {

            Numberses num = new Numberses();

            num.SumTime = time * timeNum * 3600 * servertype;       //общее время тренировки юнитов
            int factorRes;                                          //коэфициент для обычных ккм и бкбк


            //расчет для казарм
            for (int i = 0; i < valkaz.Length; i++)
            {
                factorRes = checkkaz[i] ? 3 : 1;

                if (valkaz[i] != 0)                                 //отдаем расчеты отдельному методу
                {
                    SumInfoGalUnits(num, typekaz[i], valkaz[i], factorRes);
                }
            }

            //расчет для конюшен
            for (int i = 0; i < valkon.Length; i++)
            {
                factorRes = (checkkon[i]) ? 3 : 1;

                if (valkon[i] != 0)                                 //отдаем расчеты отдельному методу
                {
                    SumInfoGalUnits(num, typekon[i], valkon[i], factorRes);
                }
            }

            //расчет для мастерской
            for (int i = 0; i < valmast.Length; i++)
            {
                if (valmast[i] != 0)                                 //отдаем расчеты отдельному методу
                {
                    SumInfoGalUnits(num, typemast[i], valmast[i]);
                }
            }

            num.SumSumValue = num.SumLuValue + num.SumClValue + num.SumIrValue + num.SumCrValue;


            ViewBag.test1 = 0;
            ViewBag.test2 = 0;
            ViewBag.test3 = 0;
            ViewBag.test4 = 0;
            ViewBag.test5 = 0;
            ViewBag.time = timeNum;

            return View(num);
        }

        public void SumInfoGalUnits(Numberses num, int typeUn, int lvlBuild, int fact = 1)        //typekaz[i], valkaz[i], factorRes
        {
            int varUnit;            //переменная для вычисления количества юнитов

            switch (typeUn)
            {
                case 1:
                    varUnit = num.SumTime / (num.Gal.Unit1.StudyTime * lvlBuild / 10000);
//                    num.SumAtack += varUnit * num.Gal.Unit1.Atack;
                    num.SumPDef += varUnit * num.Gal.Unit1.PDef;
                    num.SumKDef += varUnit * num.Gal.Unit1.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit1.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit1.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit1.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit1.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit1.Expend;
                    num.Unit1 += varUnit;
                    break;
                case 2:
                    varUnit = num.SumTime / (num.Gal.Unit2.StudyTime * lvlBuild / 10000);
                    num.SumAtack += varUnit * num.Gal.Unit2.Atack;
//                    num.SumPDef += varUnit * num.Gal.Unit2.PDef;
//                    num.SumKDef += varUnit * num.Gal.Unit2.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit2.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit2.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit2.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit2.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit2.Expend;
                    num.Unit2 += varUnit;
                    break;
                case 3:
                    varUnit = num.SumTime / (num.Gal.Unit3.StudyTime * lvlBuild / 10000);
//                    num.SumAtack += varUnit * num.Gal.Unit3.Atack;
//                    num.SumPDef += varUnit * num.Gal.Unit3.PDef;
//                    num.SumKDef += varUnit * num.Gal.Unit3.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit3.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit3.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit3.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit3.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit3.Expend;
                    num.Unit3 += varUnit;
                    break;
                case 4:
                    varUnit = num.SumTime / (num.Gal.Unit4.StudyTime * lvlBuild / 10000);
                    num.SumAtack += varUnit * num.Gal.Unit4.Atack;
//                    num.SumPDef += varUnit * num.Gal.Unit4.PDef;
//                    num.SumKDef += varUnit * num.Gal.Unit4.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit4.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit4.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit4.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit4.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit4.Expend;
                    num.Unit4 += varUnit;
                    break;
                case 5:
                    varUnit = num.SumTime / (num.Gal.Unit5.StudyTime * lvlBuild / 10000);
//                    num.SumAtack += varUnit * num.Gal.Unit5.Atack;
                    num.SumPDef += varUnit * num.Gal.Unit5.PDef;
                    num.SumKDef += varUnit * num.Gal.Unit5.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit5.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit5.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit5.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit5.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit5.Expend;
                    num.Unit5 += varUnit;
                    break;
                case 6:
                    varUnit = num.SumTime / (num.Gal.Unit6.StudyTime * lvlBuild / 10000);
                    num.SumAtack += varUnit * num.Gal.Unit6.Atack;
                    num.SumPDef += varUnit * num.Gal.Unit6.PDef;
                    num.SumKDef += varUnit * num.Gal.Unit6.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit6.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit6.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit6.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit6.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit6.Expend;
                    num.Unit6 += varUnit;
                    break;
                case 7:
                    varUnit = num.SumTime / (num.Gal.Unit7.StudyTime * lvlBuild / 10000);
                    num.SumAtack += varUnit * num.Gal.Unit7.Atack;
//                    num.SumPDef += varUnit * num.Gal.Unit7.PDef;
//                    num.SumKDef += varUnit * num.Gal.Unit7.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit7.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit7.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit7.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit7.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit7.Expend;
                    num.Unit7 += varUnit;
                    break;
                case 8:
                    varUnit = num.SumTime / (num.Gal.Unit8.StudyTime * lvlBuild / 10000);
                    num.SumAtack += varUnit * num.Gal.Unit8.Atack;
//                    num.SumPDef += varUnit * num.Gal.Unit8.PDef;
//                    num.SumKDef += varUnit * num.Gal.Unit8.KDef;
                    num.SumLuValue += varUnit * num.Gal.Unit8.LuValue * fact;
                    num.SumClValue += varUnit * num.Gal.Unit8.ClValue * fact;
                    num.SumIrValue += varUnit * num.Gal.Unit8.IrValue * fact;
                    num.SumCrValue += varUnit * num.Gal.Unit8.CrValue * fact;
                    num.SumExpend += varUnit * num.Gal.Unit8.Expend;
                    num.Unit8 += varUnit;
                    break;
                default:
                    break;
            }
        }

        /*
                [HttpPost]
                public string Index(List<string> names)
                {
                    string fin = "";
                    for (int i = 0; i < names.Count; i++)
                    {
                        fin += names[i] + ";  ";
                    }
                    return fin;
                }

        /*
                // GET: Numbers/Details/5
                public ActionResult Details(int id)
                {
                    return View();
                }

                // GET: Numbers/Create
                public ActionResult Create()
                {
                    return View();
                }

                // POST: Numbers/Create
                [HttpPost]
                public ActionResult Create(FormCollection collection)
                {
                    try
                    {
                        // TODO: Add insert logic here

                        return RedirectToAction("Index");
                    }
                    catch
                    {
                        return View();
                    }
                }

                // GET: Numbers/Edit/5
                public ActionResult Edit(int id)
                {
                    return View();
                }

                // POST: Numbers/Edit/5
                [HttpPost]
                public ActionResult Edit(int id, FormCollection collection)
                {
                    try
                    {
                        // TODO: Add update logic here

                        return RedirectToAction("Index");
                    }
                    catch
                    {
                        return View();
                    }
                }

                // GET: Numbers/Delete/5
                public ActionResult Delete(int id)
                {
                    return View();
                }

                // POST: Numbers/Delete/5
                [HttpPost]
                public ActionResult Delete(int id, FormCollection collection)
                {
                    try
                    {
                        // TODO: Add delete logic here

                        return RedirectToAction("Index");
                    }
                    catch
                    {
                        return View();
                    }
                }
        */
    }
}
