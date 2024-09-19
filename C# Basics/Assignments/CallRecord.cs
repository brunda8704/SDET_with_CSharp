using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public int CallId {  get; set; }
        public long PhoneNumber {  get; set; }
        public long CallTime {  get; set; }

        public static List<CallRecord> CallRecords = new List<CallRecord>()
        { 
            new CallRecord { CallId = 145, PhoneNumber = 9846745678, CallTime = 2 },
            new CallRecord { CallId = 145, PhoneNumber = 9846745678, CallTime = 2 },
            new CallRecord { CallId = 746, PhoneNumber = 9647476453, CallTime = 4 },
            new CallRecord { CallId = 567, PhoneNumber = 9745698563, CallTime = 7 },
        };
        public void CallHistory(long phoneNumber)
        {
            var found=CallRecords.FindAll(x => x.PhoneNumber == phoneNumber);
            if (found.Count>0) 
            {
                foreach(var record in found)
                {
                    Console.WriteLine("Call Id:" + record.CallId);
                    Console.WriteLine("Call Time:" + record.CallTime);
                }   
            }
            else
            {
                Console.WriteLine("Call history not found");
            }
        }

        public void TotalNoOfCalls()
        {

            Dictionary<long,long> calls = new Dictionary<long,long>();
            foreach(var record in CallRecords)
            {
                if(calls.ContainsKey(record.PhoneNumber))
                {
                    calls[record.PhoneNumber]++;
                }
                else
                {
                    calls[record.PhoneNumber] = 1;
                }
            }
            Console.WriteLine("\nTotal number of calls per phone number");
            foreach (var item in calls)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }

    }
}
