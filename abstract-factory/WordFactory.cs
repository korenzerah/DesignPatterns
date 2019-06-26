namespace DesignPatterns.abstract_factory
{
    public class WordFactory : DocumentMakerFactoryBase
    {
        public WordFactory()
        {
        }

        public override DocumentBodyBase createBody(Data d)
        {
            return new WordBody();
        }

        public override DocumentCaptionBase createCaption(Data d)
        {
            return new WordCaption();
        }

        public override DocumentFooterBase createFooter(Data d)
        {
            return new WordFooter();
        }

        public override DocumentGraphicsBase createGraphics(Data d)
        {
            return new WordGraphics();
        }
    }
}