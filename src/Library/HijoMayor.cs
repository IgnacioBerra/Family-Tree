using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class HijoMayor : IVisitor
    {
        public int Older = 0;
        public void Visit(Node node)
        {
            
           if(node.children.Count > 0)
           {
            foreach (Node element in node.children)
            {
                if (element.Person.Age > Older)
                {
                    Older = element.Person.Age;
                }
            }
         }
         else
            {
                return;
            }
        }
    }
}
