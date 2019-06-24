namespace DesignPatterns.builder
{
    public class ChickenSaladBuilder : SaladBuilder
    {
        protected override void prepareMain()
        {
            this.salad.prepareMain("Chicken");
        }

        protected override void preparePrice()
        {
            this.salad.preparePrice("5");
        }

        protected override void prepareSauces()
        {
            this.salad.prepareSauces("Mayonaisse");
        }

        protected override void prepareTopping()
        {
            this.salad.prepareSauces("Avocado");
        }

        protected override void prepareVegg()
        {
            this.salad.prepareSauces("Cucumber");
        }
    }
}