using System;

namespace DesignPatterns
{
    class MainOfCOR
    {
        static void Example(string[] args)
        {
            new BillT(200).setNext(new BillT(100)).setNext(new BillT(50)).setNext(new BillT(20)).handle(5000);
        }
    }
}
