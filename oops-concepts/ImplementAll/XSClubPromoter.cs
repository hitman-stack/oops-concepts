using System;

public class XSClubPromoter : Promoter, IBodyBuilder , IVlogger
{
    public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my linkdn connections.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I use facebook ads");
    }
    public void Vlog()
    {
        Console.WriteLine("I use DSLR for vlogging.");
    }

    public void Workout()
    {
        Console.WriteLine("I love working out specially cardio and weight training.");
    }

}