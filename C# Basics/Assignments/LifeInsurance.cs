using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : InsurancePolicy1
    {
        public int Age {  get; set; }
        public LifeInsurance(string? policyName, int policyId, double premiumAmount, int age)
            : base(policyName, policyId, premiumAmount)
        {
            Age = age;
        }

        public override double CalculatePremium()
        {
            if(Age <=10) 
            {
                return PremiumAmount*1.1;
            }
            else if(Age<=18)
            {
                return PremiumAmount * 1.5;
            }
            else 
            {
                return PremiumAmount * 2;
            }
            
        }
    }
}
