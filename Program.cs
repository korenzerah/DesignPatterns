﻿using System;
using System.Collections.Generic;
using DesignPatterns.abstract_factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            Data d = new Data();
            List<DocumentComponentBase> excelDoc = createDoc(new ExcelFactory(), d);
            List<DocumentComponentBase> wordDOc = createDoc(new WordFactory(), d);
        }

        private static List<DocumentComponentBase> createDoc(DocumentMakerFactoryBase factory, Data d) {
            List<DocumentComponentBase> result = new List<DocumentComponentBase>();
            result.Add(factory.createBody(d));
            result.Add(factory.createCaption(d));
            result.Add(factory.createFooter(d));
            result.Add(factory.createGraphics(d));

            return result;
        }
    }
}