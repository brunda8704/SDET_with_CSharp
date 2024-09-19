using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Electricity
    {
        int consumerNumber,prevReading,currReading;
        string? consumerName;

        //public Electricity() //default Constructor
        //{
        //    consumerNumber = 10002;
        //    consumerName = "Raj";
        //    prevReading = 9000;    
        //    currReading = 9300;
        //}

        public Electricity(int consumerNumber, int prevReading, int currReading, string? consumerName)
        {
            this.consumerNumber = consumerNumber;
            this.prevReading = prevReading;
            this.currReading = currReading;
            this.consumerName = consumerName;
        }


        public double CalculateBill()
        {
            double billAmount = 0;
            int reading = currReading - prevReading;
            if (reading <=100)
            {
                billAmount = reading * 2.00;
            }
            else if (reading <=200 && reading >=101)
            {
                billAmount = (100*2) +  ((reading-100)* 2.5);
            }
            else if (reading <= 401 && reading >= 201)
            {
                billAmount = (100*2) + (100*2.5) + ((reading-200) * 3.5);
            }
            else
            {
                billAmount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 4);
            }
            return billAmount;
        }
    }
}
