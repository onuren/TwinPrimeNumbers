using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikizAsallar
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecici = 2;
            for (int i = 2; i <= 500; i++)
            {
                bool asal = true;

                for (int j = 2; j < i; j++)
                {
                    if(i%j==0)
                    {
                        asal = false;
                        break;
                    }
                }
                if (asal==true)
                {
                    if ((i-gecici)==2)
                    {
                        Console.WriteLine(gecici+" "+i);
 
                    }
                   gecici = i;
                    
                }
                
            }

        }
    }
}
