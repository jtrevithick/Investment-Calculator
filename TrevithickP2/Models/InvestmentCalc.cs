using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrevithickP2.Models
{
    public class InvestmentCalc
    {
        public int cmpPerYr;
        public double interest;
        public double principle;
        public int years;

        public int CmpPerYr { get => cmpPerYr; set { Calc(); } }



        public double FutureValue { get => FutureValue; set { Calc(); } }

        public double Interest { get => interest; set { Calc(); } }

        public double Principle { get => principle; set { Calc(); } }

        public int Years { get=>years; set { Calc(); } }

        public void Calc() {
            FutureValue = principle*(1+(interest/cmpPerYr))*years;

        }

        public InvestmentCalc() {
        }

       public InvestmentCalc(double principle, int years, double interest, int numTimes) {
            Principle = principle;
            Years = years;
            Interest = interest;
            cmpPerYr = numTimes;
        }
    }
}
