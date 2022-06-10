class circulo:Figura
{
    public double pi;
    public double Radio;

    public circulo(string nombre,string color, double Radio, double pi):base(nombre, color)
    {
        this.Radio = Radio;
        this.pi = pi;
    }
    
    public override void Calcular()
    {
        double Area;
        double Radio2;
        Radio2= Radio*Radio;
        Area= Radio2*pi;
        Console.WriteLine("el area del circulo es de: " + Area);
    }
    public void ImprimirCir()
    {
        Console.WriteLine("el nomre de la fifura es: " + nombre + "  el color de la figura es : " + color);
    }
}