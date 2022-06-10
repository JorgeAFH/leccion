using System;
abstract class Figura
{

    public string nombre;
    public string color;


    public Figura(string nombre,string color)
    {
        this.nombre = nombre;
        this.color = color;
    }
    public abstract void Calcular();
}