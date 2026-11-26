using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Netologia0
{
    public struct Interval
    {
        private static readonly Random rand = new Random();
        private int min;
        private int max;
        public int Min { get { return min; } }
        public int Max { get { return max; } }
        public int Get { get { return rand.Next(min, max); } }
        public Interval(int minValue, int maxValue)
        {
            min = minValue;
            max = maxValue;
            if (minValue > maxValue)
            {
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
                Console.WriteLine("Некорректный ввод данных");
            }
            if (minValue <= 0)
            {
                minValue = 0;
                Console.WriteLine("Некорректный ввод данных");
            }
            if (maxValue <= 0)
            {
                maxValue = 0;
                Console.WriteLine("Некорректный ввод данных");
            }
            if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Некорректный ввод данных");
            }
        }
    }
    public struct Room
    {
        public static Unit UnitRef;
        public static Weapon WeaponRef;
        public static Weapon WeaponRef2;
        public Room(object unit,object weapon,object weapon2)
        {
            unit = UnitRef;
            weapon = WeaponRef2;
        }
    }
    public class Dungeon
    {
        public Room[] room;
        public Dungeon()
        {
            room = new Room[] {new Room(new Unit("Hero"), new Weapon("Sword"), new Weapon("Axe"))};
        }
        public void ShowRooms()
        {
            for (int i = 0; i < room.Length; i++)
            {
                var rooms = room[i];
                Console.WriteLine("Unit of room" + Room.UnitRef);
                Console.WriteLine("Weapon of room" + Room.WeaponRef);
                Console.WriteLine("Weapon of room" + Room.WeaponRef2);
            }
        }
    }
}
