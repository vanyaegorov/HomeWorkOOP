using System.Collections.Generic;
using System.Collections;
using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable date = new Hashtable();
            Building b = Creator.CreateBuilding(3,12,4,8);
            b.PrintBuildDate();
            Console.WriteLine($"Высота этажа:{b.FloorHeight()}");
            Console.WriteLine($"Количество квартир в подъезде:{b.ApartmentsAtTheEntrance()}");
            Console.WriteLine($"Количество квартир на этаже:{b.ApartmentsAtTheFloor()}");
            Building c = Creator.CreateBuilding();
            c.PrintBuildDate();//Проверка что уникальный номер меняется
            Building d = Creator.CreateBuilding(1,2,3,4);
            Creator.AddHeshTable(d, date);
            d.PrintBuildDate();

        }
    }
}
