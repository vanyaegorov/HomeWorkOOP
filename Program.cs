using System;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(1000, "debit");
            BankAccount newba = new BankAccount(1000, "debit");
            Console.WriteLine(ba==newba);
            Console.WriteLine(ba != newba);
            Console.WriteLine(ba.ToString());
            Console.WriteLine(newba.ToString());
            Figure figure = new Figure();
            figure.ColorChange("green");
            figure.VisibilityChange(true);
            figure.HorizontalMovement(-5);
            figure.VerticalMovement(10);
            figure.GetState();
            Point point = new Point();
            point.ColorChange("blue");
            point.HorizontalMovement(11);
            point.VerticalMovement(6);
            point.GetState();
            Rectangle rec = new Rectangle(5, 2);
            rec.ColorChange("red");
            rec.VisibilityChange(true);
            rec.HorizontalMovement(6);
            rec.VerticalMovement(4);
            rec.GetState();
            Console.WriteLine(rec.CalculateArea());
            Circle cir = new Circle(5);
            cir.ColorChange("pink");
            cir.VisibilityChange(true);
            cir.HorizontalMovement(60);
            cir.VerticalMovement(40);
            cir.GetState();
            Console.WriteLine(cir.CalculateArea());

        }
    }
}
