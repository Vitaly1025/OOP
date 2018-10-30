using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    class Investor
    {
        public string Name { get; set; }

        public bool Floor { get; set; } 

        public static  Investor[] GetInvestor()
        {
            var result = new Investor[]
            {
                new Investor(){ Name="Сидоров Петр",Floor=true},
                new Investor(){Name= "Смолова Екатерина",Floor=false},
                new Investor(){ Name="Уранов Михаил",Floor=true},
                new Investor(){ Name="Ломоносов Николай",Floor=true}
            };
            return result;
        }
    }

}
