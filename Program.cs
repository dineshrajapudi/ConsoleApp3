using System;
class Rambo
{
    private int _i;
    public int Id
    {
        set
        {
            this._i=value;
        }
        get
        {
            return this._i;
        }
    }
    //public Rambo(int a)
    //{
    //    this._i = a;
    //}
    public void Print()
    {
        //Console.WriteLine("{0}", this._i);
    }
    public static void Main()
    {
        Rambo R1 = new Rambo();
        //R1.Print();
        R1.Id = 11;
        Console.WriteLine("{0}", R1.Id);
    }
}