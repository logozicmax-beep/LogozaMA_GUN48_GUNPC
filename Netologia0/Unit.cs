using System;

namespace Netologia0
{
    public class Unit
    {
        private float health;
        public string Name { get; }
        public float Health => health;
        public int Damage { get; }
        public float Armor { get; }
        public Unit() 
        {
            this.Name = "Unknown Unit";
        }
        public Unit(string name)
        {
            Name = name;
        }
        public Unit(int damage)
        {
            this.Damage = damage = 5;
        }
        public Unit(float armor)
        {
            this.Armor = armor = 0.6f;
        }
        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }
        public bool SetDamage()
        {
            this.health = Health - 1f * Armor;
            bool isDead;
            if (Health <= 0f)
            {
                isDead = true;
            }
            else
            {
                isDead = false;
            }
            return isDead;
        }
    }
    internal class Program 
    { 
        static void Main(string[] args)
        {

        }
    }
}
