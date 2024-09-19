using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : InsurancePolicy1
    {
        public string? TypeOfVehicle {  get; set; }
        public CarInsurance(string? policyName, int policyId, double premiumAmount, string? typeOfVehicle) 
            : base(policyName, policyId, premiumAmount)
        {
            TypeOfVehicle = typeOfVehicle;
        }

        public override double CalculatePremium()
        {
            
            if (TypeOfVehicle == "Petrol")
                return PremiumAmount * 3;
            else
                return PremiumAmount * 5;
        }
    }
}
