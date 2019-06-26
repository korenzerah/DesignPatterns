﻿using System;
using DesignPatterns.memento;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
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