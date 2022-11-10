namespace Model
{
    public class Character
    {
        public Damage Damage { get; }
        public Health Health { get; }

        public Character(Health health, Damage damage)
        {
            Health = health;
            Damage = damage;
        }
    }
}
