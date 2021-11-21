using System;
using System.Linq;

namespace Traduccion_de_codigo__Clases_
{
    class Program
    {
        public static string opcion;
        class CalculoDeArea{

            private string fmarco;
            private double fpi;
            private double resultado;
            private string fmensaje;
            private string fmensaje2;

        public CalculoDeArea(){
                string marco=string.Concat(Enumerable.Repeat("*", 50));
                fmarco=marco;

                double pi=3.14;
                fpi=pi;

        }
        public void MensajeDeContinuar(){
            string mensaje="Presione cualquier tecla para regresar al menu";
            fmensaje=mensaje;
            System.Console.WriteLine(fmensaje);
        }
        public void MensajeDeError(){
            string mensaje="opcion invalida, porfavor ingrese una opcion valida";
            fmensaje2=mensaje;
            System.Console.WriteLine(fmensaje2);
        }
        public void Titulo(){
            System.Console.WriteLine(fmarco+"\n\t PROGRAMA PARA GEOMETRIA \n"+fmarco);
            Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir\n\n");

        }
        public void AreaDelCirculo(){
            Console.WriteLine("Para calcular el area del circulo \nIngrese el Radio");
            double vradio = Int32.Parse(Console.ReadLine());
            Double x= (Double) vradio;
            resultado= fpi*(x*x);
            System.Console.WriteLine("el resultado es: " + resultado);
            
        }
        public void AreaDelRectangulo(){
            Console.WriteLine("Para calcular el area del rectangulo\n");
            Console.WriteLine("Ingrese la Base");
            double vbase = Int32.Parse(Console.ReadLine());
            Double x= (Double) vbase;
            Console.WriteLine("Ingrese la Altura");
            double valtura = Int32.Parse(Console.ReadLine());
            Double y= (Double) valtura;
            resultado=vbase*valtura;
            System.Console.WriteLine("el resultado es: " + resultado);
        }
        public void AreaDelTriangulo(){
            Console.WriteLine("Para calcular el area del triangulo\n");
            Console.WriteLine("Ingrese la Base");
            double vbase = Int32.Parse(Console.ReadLine());
            Double x= (Double) vbase;
            Console.WriteLine("Ingrese la Altura");
            double valtura = Int32.Parse(Console.ReadLine());
            Double y= (Double) valtura;
            resultado=(valtura*vbase)/2;
            System.Console.WriteLine("el resultado es: " + resultado);
        }

        }
        static void Main(string[] args)
        {
            
            CalculoDeArea Area= new CalculoDeArea();

            Area.Titulo();
            while (opcion != "s" || opcion!="S"){
            System.Console.WriteLine("Ingrese su opcion: "); 
            opcion=Console.ReadLine();
            System.Console.WriteLine();
            Console.Clear();
            if (opcion=="s"){
                System.Console.WriteLine("\n\nGracias por usar el programa de cálculo geométrico\n\n"); 
                break;
            }
            else if (opcion=="c" || opcion=="C"){
                Area.AreaDelCirculo();
                Area.MensajeDeContinuar();
                Console.ReadKey();
                Console.Clear();
                Area.Titulo();
            }
            else if (opcion=="r" || opcion=="R"){
                Area.AreaDelRectangulo();
                Area.MensajeDeContinuar();
                Console.ReadKey();
                Console.Clear();
                Area.Titulo();
            }else if (opcion=="t" || opcion=="T"){
                Area.AreaDelTriangulo();
                Area.MensajeDeContinuar();
                Console.ReadKey();
                Console.Clear();
                Area.Titulo();
            }
            else{
                Area.MensajeDeError();
                Area.MensajeDeContinuar();
                Console.ReadKey();
                Console.Clear();
                Area.Titulo();
            }
            }
        }
    }
}
