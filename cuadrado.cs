class cuadrado:Figura
{
    public int lados;

    public cuadrado(string nombre,string color, int lados):base(nombre, color)
    {
        this.lados = lados;
    }
    
    public override void Calcular()
    {
        int Area;
        Area= lados*lados;
        Console.WriteLine("el area del cuadrado es de: " + Area);
    }
    public void ImprimirCua()
    {
        Console.WriteLine("el nomre de la fifura es: " + nombre + "  el color de la figura es : " + color);
    }
} 