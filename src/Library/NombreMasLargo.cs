using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NombreMasLargo : IVisitor
    {
        public string Longer = "";
        public int CantCaract = 0 ;
        public void Visit(Node node)
        {
          
                if(node.Person.Name.Length > CantCaract )
                {
                    Longer = node.Person.Name;
                    CantCaract = node.Person.Name.Length;
                }  
        }
    }
}