using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Los distintos VISITORES de los NODES. 
            AgeCalculator AGC = new AgeCalculator();
            HijoMayor HM = new HijoMayor();
            NombreMasLargo NML = new NombreMasLargo();

            // NODES. 
            Node n1 = new Node("Nacho",12);
            Node n2 = new Node("Berra",65);
            Node n3 = new Node("Berrulis",100);
            Node n4 = new Node("Nachote",66);
            Node n5 = new Node("Nach",12);
            Node n6 = new Node("IBerra",68);
            Node n7 = new Node("BerraNacho",32);


            //Lista con los nodes que necesito 
            //recorrerlos y aceptar las visitas.

            List<Node> NodeList = new List<Node> {n1, n2, n3, n4, n5, n6, n7};


            // Agregado de hijos que ya venía con el programa.
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // Hable con Bruno y podía hacer el Foreach dentro de la clase
            // node para aceptar los visitores o mismo en el program.
            // Preferí hacerlo en Program para ver el proceso a la hora de ejecutar
            // el program con dotnet run. 

            foreach (Node Node in NodeList)
            {
                Node.Accept(AGC);
                Node.Accept(HM);
                Node.Accept(NML);
            }

            // Verificar si funciona los diferentes métodos
            // de los visitantes.

            Console.WriteLine(HM.Older);
            Console.WriteLine(AGC.Calculo);
            Console.WriteLine(NML.Longer);

            
        }
    }
}
