partial class MyFrac
{
    public static double DoubleValue(MyFrac f)
    {
        return (double)f.nom / f.denom;
    }
    public static MyFrac operator +(MyFrac f1, MyFrac f2)
    {
        return new MyFrac(f1.nom * f2.denom + f1.denom * f2.nom, f1.denom * f2.denom);
    }
    public static MyFrac operator -(MyFrac f1, MyFrac f2)
    {
        return new MyFrac(f1.nom * f2.denom - f1.denom * f2.nom, f1.denom * f2.denom);
    }
    public static MyFrac operator *(MyFrac f1, MyFrac f2)
    {
        return new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
    }
    public static MyFrac operator /(MyFrac f1, MyFrac f2)
    {
        return new MyFrac(f1.nom * f2.denom, f1.denom * f2.nom);
    }


}
