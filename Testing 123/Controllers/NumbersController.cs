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

            ViewBag.test1 = number.Gal.Phal.StudyTime;
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
                if (typekaz[i] == 1 && valkaz[i] != 0)    //деф пехота
                {
                    num.Unit1 += num.SumTime / (10 * num.Gal.Phal.StudyTime / valkaz[i]);
                }
                if (typekaz[i] == 2 && valkaz[i] != 0)    //офф пехота
                {
                    num.Unit2 += num.SumTime / (10 * num.Gal.Sword.StudyTime / valkaz[i]);
                }
            }

            //расчет для конюшен
            for (int i = 0; i < valkon.Length; i++)
            {
                if (typekon[i] == 3 && valkon[i] != 0)    //разведы кони
                {
                    num.Unit3 += num.SumTime / (10 * num.Gal.Path.StudyTime / valkon[i]);
                }
                if (typekon[i] == 4 && valkon[i] != 0)    //офф кони
                {
                    num.Unit4 += num.SumTime / (10 * num.Gal.Theutates.StudyTime / valkon[i]);
                }
                if (typekon[i] == 5 && valkon[i] != 0)    //деф кони
                {
                    num.Unit5 += num.SumTime / (10 * num.Gal.Druid.StudyTime / valkon[i]);
                }
                if (typekon[i] == 6 && valkon[i] != 0)    //офф/деф кони
                {
                    num.Unit6 += num.SumTime / (10 * num.Gal.Haed.StudyTime / valkon[i]);
                }
            }

            //расчет для мастерской
            for (int i = 0; i < valmast.Length; i++)
            {
                if (typemast[i] == 7 && valmast[i] != 0)   //офф тараны
                {
                    num.Unit7 += num.SumTime / (10 * num.Gal.Ram.StudyTime / valmast[i]);
                }
                if (typemast[i] == 8 && valmast[i] != 0)   //офф каты
                {
                    num.Unit8 += num.SumTime / (10 * num.Gal.Treb.StudyTime / valmast[i]);
                }
            }


            int atack = num.Gal.Sword.Atack;

            ViewBag.test1 = num.SumPAtack;
            ViewBag.test2 = atack;
            ViewBag.test3 = num.SumTest;
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
