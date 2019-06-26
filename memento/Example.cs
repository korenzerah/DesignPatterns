using System;

namespace DesignPatterns.memento
{
    class MainOfMemento
    {
        static void Example(string[] args)
        {
            TextEditor te = new TextEditor();
            te.modifyText("koren");
            te.modifyText("koren zerah");
            Console.WriteLine(te.text);
            te.ctrlZ();
            Console.WriteLine(te.text);
        }
    }
}
