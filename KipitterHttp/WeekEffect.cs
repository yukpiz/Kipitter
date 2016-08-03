using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KipitterCore
{
    public struct WeekEffect
    {
        public string RealWeekJp;
        public string ErinnWeekJp;
        public string ErinnWeekEn;
        public string[] Effects;
        public string[] FlcItems;

        public WeekEffect(string realWeekJp, string erinnWeekJp,
            string erinnWeekEn, string[] effects, string[] flcItems)
        {
            RealWeekJp = realWeekJp;
            ErinnWeekJp = erinnWeekJp;
            ErinnWeekEn = erinnWeekEn;
            Effects = effects;
            FlcItems = flcItems;
        }
    }
}
