using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testing_123.Infrastructure
{
    public interface IUnits
    {
        int Atack { get; }     //атака юнита
        int PDef { get; }       //защита от пехоты
        int KDef { get; }       //защита от конницы
        int LuValue { get; }    //стоимость обучения 1 юнита в дереве
        int ClValue { get; }    //стоимость обучения 1 юнита в глине
        int IrValue { get; }    //стоимость обучения 1 юнита в железе
        int CrValue { get; }    //стоимость обучения 1 юнита в зерне
        int SumValue { get; }   //стоимость обучения 1 юнита в униресе
        int Speed { get; }      //скорость передвижения
        int Cargo { get; }      //вместительность юнита
        int Expend { get; }     //потребление зерна
        int StudyTime { get; }  //время обучения в секундах
    }
}