namespace Characters
{
    public class Hero : MonoBehaviour
    {
        public int currentHealth;
        public int attack;
        public int skill;
        public int defense;

        public int calculateDamage() {
            int damage;

            damage = (this.attack + this.skill) - this.defense;

            return damage;
        }

        public void changeHealth(int damage) {
            this.currentHealth = this.currentHealth - damage;
        }
    }
}