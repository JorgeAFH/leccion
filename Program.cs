using System;

namespace leccion
{
    class Program
    {
        static void Main(string[] args)
        {
            cuadrado llamadacuadrado1 = new cuadrado("cuadradao 1", "negro", 4);
            llamadacuadrado1.ImprimirCua();
            rectangulo llamadarectangulo1 = new rectangulo("rectangulo 1", "blanco", 5, 7);
            llamadarectangulo1.ImprimirRec();
            circulo llamadacirculo1 = new circulo("rectangulo", "verde", 3, 3.14);
            llamadacirculo1.ImprimirCir();

            List<Figura> listFiguras = new List<Figura>();
                listFiguras.Add(llamadacuadrado1);
                listFiguras.Add(llamadarectangulo1);
                listFiguras.Add(llamadacirculo1);
            
            foreach(Figura item in listFiguras)
            {
                item.Calcular();
            }
            //Math.Pow(R2, 2);
        }
    }
}