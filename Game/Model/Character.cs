namespace Model
{
    public sealed class Character : Model
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
