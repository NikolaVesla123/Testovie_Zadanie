using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovoe_1
{
    class Elevator
    {
        private int currentFloor = 1, minFloor = 0, maxFloor = 0;

        public Elevator(int _minFloor, int _maxFloor)
        {
            minFloor = _minFloor;
            maxFloor = _maxFloor;
        }

        int getCurrentFloor()
        {
            return currentFloor;
        }

        int moveDown()
        {
            if (currentFloor - 1 >= minFloor)
            {
                currentFloor--;
                Console.WriteLine("CurrentFloor is: " + currentFloor);
            }
            else
            {
                Console.WriteLine("MinimumFloor is: " + minFloor);
                return 0;
            }
            return currentFloor;
        }

        int moveUP()
        {
            if (currentFloor + 1 >= minFloor)
            {
                currentFloor++;
                Console.WriteLine("CurrentFloor is: " + currentFloor);
            }
            else
            {
                Console.WriteLine("MaximumFloor is: " + maxFloor);
                return 0;
            }
            return currentFloor;
        }

        public int move(int floor)
        {
            if (floor < minFloor)
            {
                Console.WriteLine("MinimumFloor is: " + minFloor);
                return 0;
            }
            if (floor > maxFloor)
            {
                Console.WriteLine("MaximumFloor is: " + maxFloor);
                return 0;
            }

            if (currentFloor < floor)
            {
                while (currentFloor < floor)
                {
                    moveUP();
                }
            }
            else
            {
                while (currentFloor > floor)
                {
                    moveDown();
                }
            }
            return 0;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator(-3, 26);
            while (true)
            {
                Console.WriteLine("Введите номер этажа: ");
                int floor = Convert.ToInt32(Console.ReadLine());
                elevator.move(floor);
            }

        }
    }
}
