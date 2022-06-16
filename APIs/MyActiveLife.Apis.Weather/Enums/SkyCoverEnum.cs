using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Apis.Weather.Enums
{
    [Flags]
    public enum SkyCoverEnum
    {
        Unknown = 0x0,
        SKC = 0x01,
        CLR = 0x02,
        CAVOK = 0x04,
        FEW = 0x08,
        SCT = 0x10,
        BKN = 0x20,
        OVC = 0x40,
        OVX = 0x80
    }
}
