using System;

namespace Model
{
    public sealed class Character : Model
    {
        public string Name { get; }
        public Health Health { get; }
        public Damage Damage { get; }

        
        public Character(string name, Health health, Damage damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }


        public void Display()
        {
            Console.WriteLine(
                $"Name: {Name}, Damage: {Damage.Value}, Health: {Health.Value}"
            );
        }
    }
}