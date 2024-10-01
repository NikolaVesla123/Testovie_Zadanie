using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeComparator
{
    class Main
    {
        static public void main()
        {

            int vasyaAge, katyaAge, mishaAge, min = -1, middle = -1, max = -1;

            Console.WriteLine("Введите возраст Васи");
            vasyaAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите возраст Кати");
            katyaAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите возраст Миши");
            mishaAge = Convert.ToInt32(Console.ReadLine());

            if (vasyaAge < 0 || vasyaAge > 120)
            {
                Console.WriteLine("Введите возраст Васи");
                vasyaAge = Convert.ToInt32(Console.ReadLine());
            }

            if (katyaAge < 0 || katyaAge > 120)
            {
                Console.WriteLine("Введите возраст Кати");
                katyaAge = Convert.ToInt32(Console.ReadLine());
            }

            if (mishaAge < 0 || mishaAge > 120)
            {
                Console.WriteLine("Введите возраст Миши");
                mishaAge = Convert.ToInt32(Console.ReadLine());
            }


            if ((vasyaAge > katyaAge && vasyaAge > mishaAge))
            {
                max = vasyaAge;
                if (katyaAge > mishaAge)
                {
                    middle = katyaAge;
                    min = mishaAge;
                }
                else
                {
                    middle = mishaAge;
                    min = katyaAge;
                }
            }
            else if ((katyaAge > vasyaAge && katyaAge > mishaAge))
            {
                max = katyaAge;
                if (vasyaAge > mishaAge)
                {
                    middle = vasyaAge;
                    min = mishaAge;
                }
                else
                {
                    middle = mishaAge;
                    min = vasyaAge;
                }
            }
            else if ((mishaAge > vasyaAge && mishaAge > katyaAge))
            {
                max = mishaAge;
                if (vasyaAge > katyaAge)
                {
                    middle = vasyaAge;
                    min = katyaAge;
                }
                else
                {
                    middle = katyaAge;
                    min = vasyaAge;
                }
            }

            if (vasyaAge == katyaAge && vasyaAge == mishaAge)
            {
                min = vasyaAge;
                middle = vasyaAge;
                max = vasyaAge;
            }

            if ((vasyaAge > katyaAge && vasyaAge > mishaAge) && (katyaAge == mishaAge))
            {
                max = vasyaAge;
                middle = katyaAge;
                min = mishaAge;
            }

            if ((katyaAge > vasyaAge && katyaAge > mishaAge) && (vasyaAge == mishaAge))
            {
                max = katyaAge;
                middle = vasyaAge;
                min = mishaAge;
            }

            if ((mishaAge > katyaAge && mishaAge > vasyaAge) && (katyaAge == vasyaAge))
            {
                max = mishaAge;
                middle = katyaAge;
                min = vasyaAge;
            }

            Console.WriteLine("Min = " + min);
            Console.WriteLine("Middle = " + middle);
            Console.WriteLine("Max = " + max);

            Console.ReadLine();

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AgeComparator.Main.main();
        }
    }
}
