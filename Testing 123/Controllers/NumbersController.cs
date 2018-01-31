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

        Numberses number = new Numberses();
            
        // GET: Numbers
        [HttpGet]
        public ActionResult Index()
        {
            Numberses num = new Numberses();

            ViewBag.test1 = 0;
            ViewBag.test2 = 0;
            ViewBag.test3 = 0;
            ViewBag.time = 0;

            

            return View(num);
        }

        //valkaz, valkon, valmast - уровни казарм, конюшен, мастерских массивом
        //typekaz, typekon, typemast - типы войск обучающихся массивом
        //time, timeNum - количество часов (час/день/неделя...), количество часов указанное в поле
        [HttpPost]
        public ActionResult Index(int[] valkaz, int[] valkon, int[] valmast, 
                                    int[] typekaz, int[] typekon, int[] typemast, 
                                    int time, int servertype = 1, int timeNum = 1)
        {

            Numberses num = new Numberses();

            num.SumTime = time * timeNum * 3600 * servertype;

            //расчет для казарм
            for (int i = 0; i < valkaz.Length; i++)
            {
                if (typekaz[i] == 1 && valkaz[i] != 0)    //деф пехота - фал
                {
                    num.Unit1 += num.SumTime / (num.Gal.Unit1.StudyTime * valkaz[i] / 10000);
                }
                if (typekaz[i] == 2 && valkaz[i] != 0)    //офф пехота - меч
                {
                    num.Unit2 += num.SumTime / (num.Gal.Unit2.StudyTime * valkaz[i] / 10000);
                }
            }

            //расчет для конюшен
            for (int i = 0; i < valkon.Length; i++)
            {
                if (typekon[i] == 3 && valkon[i] != 0)    //разведы кони - развед
                {
                    num.Unit3 += num.SumTime / (num.Gal.Unit3.StudyTime * valkon[i] / 10000);
                }
                if (typekon[i] == 4 && valkon[i] != 0)    //офф кони - гром
                {
                    num.Unit4 += num.SumTime / (num.Gal.Unit4.StudyTime * valkon[i] / 10000);
                }
                if (typekon[i] == 5 && valkon[i] != 0)    //деф кони - друль
                {
                    num.Unit5 += num.SumTime / (num.Gal.Unit5.StudyTime * valkon[i] / 10000);
                }
                if (typekon[i] == 6 && valkon[i] != 0)    //офф/деф кони - эдуй
                {
                    num.Unit6 += num.SumTime / (num.Gal.Unit6.StudyTime * valkon[i] / 10000);
                }
            }

            //расчет для мастерской
            for (int i = 0; i < valmast.Length; i++)
            {
                if (typemast[i] == 7 && valmast[i] != 0)   //офф тараны
                {
                    num.Unit7 += num.SumTime / (num.Gal.Unit7.StudyTime * valmast[i] / 10000);
                }
                if (typemast[i] == 8 && valmast[i] != 0)   //офф каты
                {
                    num.Unit8 += num.SumTime / (num.Gal.Unit8.StudyTime * valmast[i] / 10000);
                }
            }

            num.SumAtack = num.Unit2 * num.Gal.Unit2.Atack + num.Unit4 * num.Gal.Unit4.Atack 
                + num.Unit6 * num.Gal.Unit6.Atack + num.Unit7 * num.Gal.Unit7.Atack + num.Unit8 * num.Gal.Unit8.Atack;

            num.SumPDef = 0;

            num.SumKDef = 0;

            num.SumLuValue = 0;

            num.SumClValue = 0;

            num.SumIrValue = 0;

            num.SumCrValue = 0;

            num.SumSumValue = 0;


            ViewBag.test1 = num.SumAtack;
            ViewBag.test2 = 0;
            ViewBag.test3 = 0;
            ViewBag.time = timeNum;

            return View(num);
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
