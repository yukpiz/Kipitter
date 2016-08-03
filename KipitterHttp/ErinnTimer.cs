using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KipitterCore
{
    public class ErinnTimer
    {
        public static DateTime getErinnTime()
        {
            DateTime now = DateTime.Now;
            DateTime baseTime = new DateTime(
                now.Year, now.Month, now.Day, 0, 0, 0);
            TimeSpan diff = now - baseTime;

            int courseTime = (diff.Hours * 3600) + (diff.Minutes * 60) + diff.Seconds;

            int erinnCourseTime = courseTime % 2160;

            int erinnHours = (erinnCourseTime * 40) / 60 / 60;
            int erinnMinutes = (erinnCourseTime * 40) / 60 % 60;

            return new DateTime(1990, 1, 1, erinnHours, erinnMinutes, 0);
        }

        public static WeekEffect getWeekEffect()
        {
            DateTime now = DateTime.Now;
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return Constant.WeekEffect.IMBOLIC;
                case DayOfWeek.Monday:
                    return Constant.WeekEffect.ALBAN_EILER;
                case DayOfWeek.Tuesday:
                    return Constant.WeekEffect.BELTANE;
                case DayOfWeek.Wednesday:
                    return Constant.WeekEffect.ALBAN_HERUIN;
                case DayOfWeek.Thursday:
                    return Constant.WeekEffect.LUGHNASADH;
                case DayOfWeek.Friday:
                    return Constant.WeekEffect.ALBAN_ELVED;
                case DayOfWeek.Saturday:
                    return Constant.WeekEffect.SAMHAIN;
                default:
                    throw new Exception("SYSTEM ERROR");
            }
        }
    }
}