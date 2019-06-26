namespace DesignPatterns.memento
{
    public class Memento
    {
        public string currentText {get; private set;}

        public Memento(string txt)
        {
            this.currentText = txt;
        }
    }
}