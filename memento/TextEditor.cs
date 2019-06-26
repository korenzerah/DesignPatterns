namespace DesignPatterns.memento
{
    public class TextEditor
    {
        CareTaker savedText = new CareTaker();
        public string text { get; private set;}  

        public TextEditor()
        {
            this.savedText.AddMemento(new Memento(""));
        }

        public void modifyText(string newtxt) {
            this.savedText.AddMemento(new Memento(this.text));
            this.text = newtxt;
        }

        public void ctrlZ() {
            this.text = savedText.getLastMomento().currentText;
        }
    }
}