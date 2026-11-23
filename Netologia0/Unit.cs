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
        public Unit() : this("Unknown Unit") { }
        public Unit(string name)
        {
            Name = name;
            Damage = 5;
            Armor = 0.6f;
        }
        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }
        public bool SetDamage(float value)
        {
            health = Health - value * Armor;
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
}
