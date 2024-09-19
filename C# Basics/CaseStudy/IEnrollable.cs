using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal interface IEnrollable
    {

        public void CourseRegistration(List<Student> Students);
        public void CourseWithdrawl(int id);
    }
}
