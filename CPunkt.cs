using System;

class CPunkt
{
    private double x;
    private double y;

    // Standardkonstruktor
    public CPunkt()
    {
        x = 0;
        y = 0;
    }

    // Konstruktor mit zwei Parametern
    public CPunkt(double a, double b)
    {
        x = a;
        y = b;
    }

    // Kopierkonstruktor
    public CPunkt(CPunkt P)
    {
        x = P.x;
        y = P.y;
    }

    // Eigenschaften
    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public void SetzeKoordinaten(double a, double b)
    {
        x = a;
        y = b;
    }

    public double Abstand()
    {
        return Math.Sqrt(x * x + y * y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CPunkt A = new CPunkt(10, 20);
        CPunkt B = new CPunkt(A);
        CPunkt C = new CPunkt();

        C.SetzeKoordinaten(30, 40);

        Console.WriteLine("Punkt B<" + B.X + " | " + B.Y + ">");
        Console.WriteLine("Abstand von Punkt B zu <0|0>: " + B.Abstand());
    }
}
