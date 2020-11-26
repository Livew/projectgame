namespace Characters
{
    public class Hero
    {
        public CharacterClassesEnum.Classes class;
        public CharacterClassesEnum.Specialization specialization;

        public int maxHealth;
        public int health { get { return currentHealth; }}
        int currentHealth;

        public int maxMana;
        public int mana { get { return currentMana; }}
        int currentMana;
        
        public int defenseEquipment;
        public int meleeProficiency;
        public int distanceProficiency;
        public int magicProficiency;
        public int defenseProciency;
        public WeaponProficiencyEnum equippedWeaponProficiency;

        public int baseAttack;
        public int attack;
        public int attackEquipment;

        public int baseDefense;
        public int defense;
        public int defenseEquipment;

        public string status;

        
        void calculateHeroDefense(){
            this.defense = this.defenseProciency + this.defenseEquipment + this.baseDefense;
        }

        void calculateHeroAttack() {
            int proficiency = getEquippedWeaponProficiency();

            this.attack = this.proficiency + this.attackEquipment + this.baseAttack;
        }

        void changeHealth(int amount) {
            this.currentHealth = Mathf.Clamp(this.currentHealth + amount, 0, this.maxHealth);
        }

        public int getEquippedWeaponProficiency() {
            switch (this.equippedWeaponProficiency) {
                case MELEE:
                return meleeProficiency;
                break;

                case DISTANCE:
                return distanceProficiency;
                break;

                case MAGIC:
                return magicProficiency;
                break;
            }
        }
    }
}