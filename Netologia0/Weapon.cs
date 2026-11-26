using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netologia0
{
    public class Weapon
    {
        public string Name { get; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public float Durability { get; }
        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Durability = 1f;
            SetDamageParams(MinDamage,MaxDamage);
        }
        public void SetDamageParams(int minDamage,int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                int tempNum = minDamage;
                minDamage = maxDamage;
                maxDamage = tempNum;
                Console.WriteLine($"Некореректный ввод данных {Name}");
            }
            if (minDamage < 1)
            {
                Convert.ToSingle(minDamage);
                Console.WriteLine("Форсированная установка минимального значения");
            }
            if (maxDamage <= 1)
            {
                maxDamage = 10;
            }
        }
        public int GetDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }
    }
}
