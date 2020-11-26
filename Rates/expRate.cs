namespace Rates
{
    public class expRate
    {     

        public int penaltyRate(int experience) {
            return experience * 0.5;
        }

        public int normalRate(int experience) {
            return experience * 1;
        }

        public int halfRate(int experience) {
            return experience * 1.5;
        }

        public int doubleRate(int experience) {
            return experience * 2;
        }
    }
}