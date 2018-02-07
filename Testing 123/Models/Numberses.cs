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
        public int SumAtack { get; set; }
        public int SumPDef { get; set; }
        public int SumKDef { get; set; }
        public int SumLuValue { get; set; }
        public int SumClValue { get; set; }
        public int SumIrValue { get; set; }
        public int SumCrValue { get; set; }
        public int SumSumValue { get; set; }
        public int SumCargo { get; set; }
        public int SumExpend { get; set; }
        public double SumTest { get; set; }
        
        //суммирование войск по типам от 1 до 8
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
        public bool[] CheckKaz { get; set; }    //чекбокс БКБК

        public double[] ValKon { get; set; }    //уровни конюшен массивом
        public int[] TypeKon { get; set; }      //тип обучаемых войск в конюшне
        public bool[] CheckKon { get; set; }    //чекбокс БКБК

        public double[] ValMast { get; set; }   //уровни мастерских массивом
        public int[] TypeMast { get; set; }     //тип обучаемых войск в мастерской

        public Gal Gal = new Gal();

        //создание списков select'ов для обучающих зданий
        public static List<SelectListItem> BuildTrainUnit = new List<SelectListItem> {
                                            new SelectListItem { Text = "0", Value = "0", Selected = true },
                                            new SelectListItem { Text = "1", Value = "10000"},
                                            new SelectListItem { Text = "2", Value = "9000"},
                                            new SelectListItem { Text = "3", Value = "8100"},
                                            new SelectListItem { Text = "4", Value = "7290"},
                                            new SelectListItem { Text = "5", Value = "6561"},
                                            new SelectListItem { Text = "6", Value = "5905"},
                                            new SelectListItem { Text = "7", Value = "5314"},
                                            new SelectListItem { Text = "8", Value = "4783"},
                                            new SelectListItem { Text = "9", Value = "4305"},
                                            new SelectListItem { Text = "10", Value = "3874"},
                                            new SelectListItem { Text = "11", Value = "3487"},
                                            new SelectListItem { Text = "12", Value = "3138"},
                                            new SelectListItem { Text = "13", Value = "2824"},
                                            new SelectListItem { Text = "14", Value = "2542"},
                                            new SelectListItem { Text = "15", Value = "2288"},
                                            new SelectListItem { Text = "16", Value = "2059"},
                                            new SelectListItem { Text = "17", Value = "1853"},
                                            new SelectListItem { Text = "18", Value = "1668"},
                                            new SelectListItem { Text = "19", Value = "1501"},
                                            new SelectListItem { Text = "20", Value = "1351"}
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
        public Phalanx Unit1 = new Phalanx();
        public Swordsman Unit2 = new Swordsman();
        public Pathfinder Unit3 = new Pathfinder();
        public TheutatesThunder Unit4 = new TheutatesThunder();
        public Druidrider Unit5 = new Druidrider();
        public Haeduan Unit6 = new Haeduan();
        public Ram Unit7 = new Ram();
        public Trebuchet Unit8 = new Trebuchet();
    }
}