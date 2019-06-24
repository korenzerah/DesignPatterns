namespace DesignPatterns.strategy
{
    public class DataContainer
    {
        int[] data = new int[10];

        ISortStrategy sortStrategy;

        public DataContainer(ISortStrategy s) {
            this.sortStrategy = s;
        }

        public void setSortStrategy(ISortStrategy s) {
            this.sortStrategy = s;
        }

        public void Sort() {
            this.sortStrategy.Sort(this.data);
        }
    }
}