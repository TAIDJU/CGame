namespace Model
{
    public class Health
    {
        public int Value { get; private set; }


        public Health(int value)
        {
            Value = value;
        }


        public bool TryApplyDamage(Damage damage)
        {
            if (Value <= damage.Value) return false;

            Value -= damage.Value;
            return true;
        }
    }
}
