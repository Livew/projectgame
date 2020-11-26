namespace Rates
{
    public class proficiencyRate
    {
        public CharacterClassesEnum characterClass;

        public int getMeleeRate(int experience) {
            switch(characterClass) {
                case WARRIOR:
                return experience * 1.2;
                break;

                case THIEF:
                return experience * 1.2;
                break;

                case ARCHER:
                return experience * 0.9;
                break;

                case MAGE:
                return experience * 0.7;
                break;

                case PRIEST:
                return experience * 0.7;
                break;
            }
        }

        public int getDistanceRate(int experience) {
            switch(characterClass) {
                case WARRIOR:
                return experience * 0.9;
                break;

                case THIEF:
                return experience * 0.9;
                break;

                case ARCHER:
                return experience * 1.2;
                break;

                case MAGE:
                return experience * 0.9;
                break;

                case PRIEST:
                return experience * 0.9;
                break;
            }
        }

        public int getMagicRate(int experience) {
            switch(characterClass) {
                case WARRIOR:
                return experience * 0.7;
                break;

                case THIEF:
                return experience * 0.7;
                break;

                case ARCHER:
                return experience * 0.9;
                break;

                case MAGE:
                return experience * 1.3;
                break;

                case PRIEST:
                return experience * 1.3;
                break;
            }
        }
    }
}