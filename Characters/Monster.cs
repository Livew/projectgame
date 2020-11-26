namespace Characters
{
    public class Monster
    {
        public int maxHealth;
        public int health { get { return currentHealth; }}
        int currentHealth;

        public int attack;
        public int defense;

        public int experience;
        public int gold;
    }
}