using Autodesk.AutoCAD.Runtime;
using Autodesk.Civil.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSettings
{
    public class DrawingSettings
    {
        [CommandMethod("Setds")]
        public void Setds()
        {
            // Получаем доступ к чертежу
            CivilDocument doc = CivilApplication.ActiveDocument;

            // Получаем доступ к параметрам, вкладка "Еденицы измерения и зона"
            doc.Settings.DrawingSettings.UnitZoneSettings.DrawingUnits = Autodesk.Civil.Settings.DrawingUnitType.Meters;
            doc.Settings.DrawingSettings.UnitZoneSettings.AngularUnits = Autodesk.Civil.AngleUnitType.Degree;
            doc.Settings.DrawingSettings.UnitZoneSettings.ImperialToMetricConversion = Autodesk.Civil.Settings.ImperialToMetricConversionType.InternationalFoot;
            doc.Settings.DrawingSettings.UnitZoneSettings.DrawingScale = 1;

            // Переходим на вкладку "Параметры среды"
            doc.Settings.DrawingSettings.AmbientSettings.Area.Unit.Value = Autodesk.Civil.AreaUnitType.SquareMeter;
            doc.Settings.DrawingSettings.AmbientSettings.Area.Precision.Value = 5;
            doc.Settings.DrawingSettings.AmbientSettings.Area.Rounding.Value = Autodesk.Civil.RoundingType.Normal;
            doc.Settings.DrawingSettings.AmbientSettings.Area.Sign.Value = Autodesk.Civil.SignType.Always;
            doc.Settings.DrawingSettings.AmbientSettings.General.SaveCommandChangesToSettings.

        }

    }
}
