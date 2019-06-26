namespace DesignPatterns.abstract_factory
{
    public class ExcelFactory : DocumentMakerFactoryBase
    {
        public ExcelFactory()
        {
        }

        public override DocumentBodyBase createBody(Data d)
        {
            return new ExcelBody();
        }

        public override DocumentCaptionBase createCaption(Data d)
        {
            return new ExcelCaption();
        }

        public override DocumentFooterBase createFooter(Data d)
        {
            return new ExcelFooter();
        }

        public override DocumentGraphicsBase createGraphics(Data d)
        {
            return new ExcelGraphics();
        }
    }
}