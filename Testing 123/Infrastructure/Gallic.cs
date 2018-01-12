using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing_123.Infrastructure
{
    public class Gallic
    {
        //создание списка select'а для казармы
        public static List<SelectListItem> WarriorType = new List<SelectListItem> {
                                            new SelectListItem { Text = "Phalanx", Value = "1" },
                                            new SelectListItem { Text = "Swordsman", Value = "2" }
                                            };

        //создание списка select'а для конюшни
        public static List<SelectListItem> HorseType = new List<SelectListItem> {
                                            new SelectListItem { Text = "Pathfinder", Value = "3" },
                                            new SelectListItem { Text = "Theutates Thunder", Value = "4" },
                                            new SelectListItem { Text = "Druidrider", Value = "5" },
                                            new SelectListItem { Text = "Haeduan", Value = "6" },
                                            };

        //создание списка select'а для мастерской
        public static List<SelectListItem> MechanismType = new List<SelectListItem> {
                                            new SelectListItem { Text = "Ram", Value = "7" },
                                            new SelectListItem { Text = "Trebuchet", Value = "8" }
                                            };
    }

    public class Phalanx : IUnits
    {
        private int _atack = 15;
        private int _pdef = 40;
        private int _kdef = 50;
        private int _luvalue = 100;
        private int _clvalue = 130;
        private int _irvalue = 55;
        private int _crvalue = 30;
        private int _sumvalue = 315;
        private int _speed = 14;
        private int _cargo = 35;
        private int _expend = 1;
        private int _studytime = 1040;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Swordsman: IUnits
    {
        private int _atack = 65;
        private int _pdef = 35;
        private int _kdef = 20;
        private int _luvalue = 140;
        private int _clvalue = 150;
        private int _irvalue = 185;
        private int _crvalue = 60;
        private int _sumvalue = 535;
        private int _speed = 6;
        private int _cargo = 45;
        private int _expend = 1;
        private int _studytime = 1440;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Pathfinder: IUnits
    {
        private int _atack = 0;
        private int _pdef = 20;
        private int _kdef = 10;
        private int _luvalue = 170;
        private int _clvalue = 150;
        private int _irvalue = 20;
        private int _crvalue = 40;
        private int _sumvalue = 380;
        private int _speed = 17;
        private int _cargo = 0;
        private int _expend = 2;
        private int _studytime = 1360;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class TheutatesThunder: IUnits
    {
        private int _atack = 90;
        private int _pdef = 25;
        private int _kdef = 40;
        private int _luvalue = 350;
        private int _clvalue = 450;
        private int _irvalue = 230;
        private int _crvalue = 60;
        private int _sumvalue = 1090;
        private int _speed = 19;
        private int _cargo = 75;
        private int _expend = 2;
        private int _studytime = 2480;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Druidrider: IUnits
    {
        private int _atack = 45;
        private int _pdef = 115;
        private int _kdef = 55;
        private int _luvalue = 360;
        private int _clvalue = 330;
        private int _irvalue = 280;
        private int _crvalue = 120;
        private int _sumvalue = 1090;
        private int _speed = 16;
        private int _cargo = 35;
        private int _expend = 2;
        private int _studytime = 2560;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Haeduan: IUnits
    {
        private int _atack = 140;
        private int _pdef = 60;
        private int _kdef = 165;
        private int _luvalue = 500;
        private int _clvalue = 620;
        private int _irvalue = 675;
        private int _crvalue = 170;
        private int _sumvalue = 1965;
        private int _speed = 13;
        private int _cargo = 65;
        private int _expend = 3;
        private int _studytime = 3120;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Ram: IUnits
    {
        private int _atack = 50;
        private int _pdef = 30;
        private int _kdef = 105;
        private int _luvalue = 950;
        private int _clvalue = 555;
        private int _irvalue = 330;
        private int _crvalue = 75;
        private int _sumvalue = 1910;
        private int _speed = 4;
        private int _cargo = 0;
        private int _expend = 3;
        private int _studytime = 5000;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Trebuchet: IUnits
    {
        private int _atack = 70;
        private int _pdef = 45;
        private int _kdef = 10;
        private int _luvalue = 960;
        private int _clvalue = 1450;
        private int _irvalue = 630;
        private int _crvalue = 90;
        private int _sumvalue = 3130;
        private int _speed = 3;
        private int _cargo = 0;
        private int _expend = 6;
        private int _studytime = 9000;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Chieftain: IUnits
    {
        private int _atack = 40;
        private int _pdef = 50;
        private int _kdef = 50;
        private int _luvalue = 30750;
        private int _clvalue = 45400;
        private int _irvalue = 31000;
        private int _crvalue = 37500;
        private int _sumvalue = 144650;
        private int _speed = 5;
        private int _cargo = 0;
        private int _expend = 4;
        private int _studytime = 90700;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }

    public class Settler: IUnits
    {
        private int _atack = 0;
        private int _pdef = 80;
        private int _kdef = 80;
        private int _luvalue = 4400;
        private int _clvalue = 5600;
        private int _irvalue = 4200;
        private int _crvalue = 3900;
        private int _sumvalue = 18100;
        private int _speed = 5;
        private int _cargo = 3000;
        private int _expend = 1;
        private int _studytime = 22700;

        public int Atack => _atack;
        public int PDef => _pdef;
        public int KDef => _kdef;
        public int LuValue => _luvalue;
        public int ClValue => _clvalue;
        public int IrValue => _irvalue;
        public int CrValue => _crvalue;
        public int SumValue => _sumvalue;
        public int Speed => _speed;
        public int Cargo => _cargo;
        public int Expend => _expend;
        public int StudyTime => _studytime;
    }
}