namespace DesignPatterns.exam.exercise5
{
    public static class LogFactory
    {
        public static ILog GetLogWritter(LogEnum logType) {
            switch(logType){
                case(LogEnum.Info): {
                    return new InfoLog();
                }
                case(LogEnum.Error): {
                    return new ErrorDecorator(new InfoLog());
                }
                case(LogEnum.Fatal): {
                    return new FatalDecorator(new ErrorDecorator(new InfoLog()));
                }default: {
                    return new InfoLog();
                }
            }
        }
    }
}