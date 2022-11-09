using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AgeCalculator:IVisitor
    {
        public int Calculo{get;set;}

        public AgeCalculator()
        {
            this.Calculo = 0;
        }
        public void Visit(Node node)
        {
            Calculo = Calculo + node.Person.Age;
        }
    }
}
