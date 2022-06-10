class rectangulo:Figura
{
    public int altura;
    public int basee;

    public rectangulo(string nombre,string color, int altura, int basee):base(nombre, color)
    {
        this.altura = altura;
        this.basee = basee;
    }
    
    public override void Calcular()
    {
        int Area;
        Area= basee*altura;
        Console.WriteLine("el area del rectangulo es de: " + Area);
    }
    public void ImprimirRec()
    {
        Console.WriteLine("el nomre de la fifura es: " + nombre + "  el color de la figura es : " + color);
    }
}