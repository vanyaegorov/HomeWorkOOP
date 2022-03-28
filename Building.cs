using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    public class Building
    {
        private int _uniqueNumber;
        private int _floor;
        private int _apartment;
        private int _entrance;
        private float _height;
        public static int actualNumber;

        public int UniqueNumber
        {
            get { return _uniqueNumber; }
        }

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public int Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }

        public int Entrance
        {
            get { return _entrance; }
            set { _entrance = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

       public Building()
            {
            if (actualNumber != 0)
            {
                actualNumber += 1;
                _uniqueNumber = actualNumber;
            }
            else
            {
                _uniqueNumber = 1;
                actualNumber = 1;
            }
            
            }
        public float FloorHeight()
        {
            if (_height != 0 && _floor != 0)
            {
                float floorHeight = _height / (float)_floor;
                return floorHeight;
            }
            else
                return 0;
        }

        public int ApartmentsAtTheEntrance()
        {
            if (_apartment != 0 && _entrance != 0)
            {
                int apartmentsAtTheEntrance = _apartment / _entrance;
                return apartmentsAtTheEntrance;
            }
            else
                return 0;
        }

        public int ApartmentsAtTheFloor()
        {
            if (_apartment != 0 && _floor != 0)
            {
                int apartmentsAtTheFloor = _apartment / _floor;
                return apartmentsAtTheFloor;
            }
            else
                return 0;
        }

        public void PrintBuildDate()
        {
            Console.WriteLine($"Уникальный номер:{_uniqueNumber}");
            Console.WriteLine($"Количество квартир:{_apartment}");
            Console.WriteLine($"Количество этажей:{_floor}");
            Console.WriteLine($"Количество подъездов:{_entrance}");
            Console.WriteLine($"Высота здания:{_height}");
        }

    }
}
