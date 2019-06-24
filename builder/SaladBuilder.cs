namespace DesignPatterns.builder
{
    public abstract class SaladBuilder
    {
        protected Salad salad;
        public virtual void buildSalad() {
            this.salad = new Salad();
            this.prepareMain();
            this.prepareVegg();
            this.prepareSauces();
            this.prepareTopping();
            this.preparePrice();            
        }
        protected abstract void prepareMain();
        protected abstract void prepareVegg();
        protected abstract void prepareTopping();
        protected abstract void prepareSauces();
        protected abstract void preparePrice();
        
        public override string ToString() {
            return this.salad.ToString();
        }
    }
}