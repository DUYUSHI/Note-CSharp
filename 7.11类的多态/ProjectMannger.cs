using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11类的多态
{
    class ProjectMannger : Clerk 
    {
        public override void WorkPlan()
        {
            Console.WriteLine("项目经理，也需要工作计划！");
        }
    }
}
