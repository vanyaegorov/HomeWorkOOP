using System.Collections;
using System.Collections.Generic;
namespace lesson4
{
    public class Creator
    {
        HashSet<Building> hashset = new HashSet<Building>();
        public static Building CreateBuilding()
        {
            Building build = new Building();
            return build;
        }
        public static Building CreateBuilding(int floor,int apartmen,int entrance,float height)
        {
            Building build = new Building();
            build.Floor = floor;
            build.Apartment = apartmen;
            build.Entrance = entrance;
            build.Height = height;
            return build;
        }
        public static void AddHeshTable(Building build,Hashtable z)
        {
            z.Add(build.UniqueNumber,build);
        }


        
    }
}
