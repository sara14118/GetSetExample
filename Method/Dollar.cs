using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Dollar
    {

        public decimal Amount;


        public decimal Amount2
        {
            get
            {
                return this.Amount;
            }
            set
            {
                this.Amount = value;
            }
        }

        public Dollar(decimal amount)
        {
                if (amount <= 0)
            {
                this.Amount = 0;
            }
        }
        
    } 
   
    
   
}
