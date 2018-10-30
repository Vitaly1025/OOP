using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    class Contribution
    {
        public string Type { get; set; }
        
        public string Date { get; set; }

        public string Money { get; set; }

        public Investor Investor { get; set; }

        public static Contribution[] GetContribution()
        {
            var result = new Contribution[]
            {
                new Contribution(){Type="Вклад",Date="21-03-2016", Money="230$",Investor=Investor.GetInvestor()[0]},
                new Contribution(){Type="Дипозит",Date="21-01-2016", Money="150$",Investor=Investor.GetInvestor()[1]},
                new Contribution(){Type="Рассрочка",Date="21-03-2016", Money="50$",Investor=Investor.GetInvestor()[2]},
                new Contribution(){Type="Кредит",Date="21-03-2012", Money="1590$",Investor=Investor.GetInvestor()[3]}
            };
            return result;
        }
    }
}
