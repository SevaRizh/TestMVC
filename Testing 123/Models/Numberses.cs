using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Testing_123.Infrastructure;

namespace Testing_123.Models
{
    public class Numberses
    {
        public double SumPAtack { get; set; }
        public double SumTest { get; set; }
        
        public int Unit1 { get; set; }
        public int Unit2 { get; set; }
        public int Unit3 { get; set; }
        public int Unit4 { get; set; }
        public int Unit5 { get; set; }
        public int Unit6 { get; set; }
        public int Unit7 { get; set; }
        public int Unit8 { get; set; }

        public int time { get; set; }           //единица измерения времени час/сутки/неделя/месяц
        public int timeNum { get; set; }        //множитель единиц измерения времени
        public int SumTime { get; set; }        //общее время обучения юнитов
        public int serverType { get; set; }     //скорость сервера Т4/Т4х3/finals
        
        public double[] ValKaz { get; set; }    //уровни казарм массивом
        public int[] TypeKaz { get; set; }      //тип обучаемых войск в казарме
        public double[] ValKon { get; set; }    //уровни конюшен массивом
        public int[] TypeKon { get; set; }      //тип обучаемых войск в конюшне
        public double[] ValMast { get; set; }   //уровни мастерских массивом
        public int[] TypeMast { get; set; }     //тип обучаемых войск в мастерской

        public Gal Gal = new Gal();

        //создание списков select'ов для обучающих зданий
        public static List<SelectListItem> BuildTrainUnit = new List<SelectListItem> {
                                            new SelectListItem { Text = "0", Value = "0", Selected = true },
                                            new SelectListItem { Text = "1", Value = "10"},
                                            new SelectListItem { Text = "2", Value = "11"},
                                            new SelectListItem { Text = "3", Value = "12"},
                                            new SelectListItem { Text = "4", Value = "14"},
                                            new SelectListItem { Text = "5", Value = "15"},
                                            new SelectListItem { Text = "6", Value = "17"},
                                            new SelectListItem { Text = "7", Value = "19"},
                                            new SelectListItem { Text = "8", Value = "21"},
                                            new SelectListItem { Text = "9", Value = "23"},
                                            new SelectListItem { Text = "10", Value = "26"},
                                            new SelectListItem { Text = "11", Value = "29"},
                                            new SelectListItem { Text = "12", Value = "32"},
                                            new SelectListItem { Text = "13", Value = "35"},
                                            new SelectListItem { Text = "14", Value = "39"},
                                            new SelectListItem { Text = "15", Value = "44"},
                                            new SelectListItem { Text = "16", Value = "49"},
                                            new SelectListItem { Text = "17", Value = "54"},
                                            new SelectListItem { Text = "18", Value = "60"},
                                            new SelectListItem { Text = "19", Value = "67"},
                                            new SelectListItem { Text = "20", Value = "74"}
                                            };

        //создание списка select'a для времени
        public static List<SelectListItem> RealTime = new List<SelectListItem> {
                                            new SelectListItem { Text = "hour", Value = "1" },
                                            new SelectListItem { Text = "day", Value = "24" },
                                            new SelectListItem { Text = "week", Value = "168" },
                                            new SelectListItem { Text = "month", Value = "732" },
                                            new SelectListItem { Text = "year", Value = "8760" }
                                            };

        //создание списка select'а для типа сервера
        public static List<SelectListItem> ServerType = new List<SelectListItem> {
                                            new SelectListItem { Text = "T4", Value = "1"},
                                            new SelectListItem { Text = "T4 x3", Value = "3"},
                                            new SelectListItem { Text = "finals", Value = "2"}
                                            };

    }

    public class Gal
    {
        public Swordsman Sword = new Swordsman();
        public Phalanx Phal = new Phalanx();
        public Pathfinder Path = new Pathfinder();
        public TheutatesThunder Theutates = new TheutatesThunder();
        public Druidrider Druid = new Druidrider();
        public Haeduan Haed = new Haeduan();
        public Ram Ram = new Ram();
        public Trebuchet Treb = new Trebuchet();
    }

    public class Summary
    {
        public double SumPAtack { get; set; }
        public double SumPDef { get; set; }
    }
}