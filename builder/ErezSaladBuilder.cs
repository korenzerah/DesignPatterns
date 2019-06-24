namespace DesignPatterns.builder
{
    public class ErezSaladBuilder : SaladBuilder
    {   
        public override void buildSalad() {
            this.salad = new Salad();
            this.prepareSauces();
        }
        protected override void prepareMain()
        {
            // this.salad.prepareMain("Chicken");
        }

        protected override void preparePrice()
        {
            // this.salad.preparePrice("5");
        }

        protected override void prepareSauces()
        {
            this.salad.prepareSauces("Mayonaisse");
        }

        protected override void prepareTopping()
        {
            // this.salad.prepareSauces("Avocado");
        }

        protected override void prepareVegg()
        {
            // this.salad.prepareSauces("Cucumber");
        }
    }
}