using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragim.Services
{
    public delegate void PromotionDelegate(int anyNumber);
    class WorkersPromotion
    {
        
        public void PromoteByAge(int age)
        {
            if(age > 40)
            {
                Console.WriteLine("Promoted");
            }
            else
            {
                Console.WriteLine("not promoted");
            }
        }

        public void PromoteByExperience(int serviceYears)
        {
            if(serviceYears > 5)
            {
                Console.WriteLine("Promoted");
            }
            else
            {
                Console.WriteLine("Not promoted");
            }
        }
    }
}
