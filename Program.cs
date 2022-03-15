using System;

class Program
{
    static void Main()
    {
        FiguresList List = new();

        List.AddFigureToList(new Dot(0, 0));
        List.AddFigureToList(new Line(0f, 0f));
        List.AddFigureToList(new Circle(0f, 0f));
        List.AddFigureToList(new Rectangle(0f, 0f));
        List.AddFigureToList(new Treangle(0f, 0f));
        List.AddFigureToList(new Rhombus(0f, 0f));

        List.PrintFigures(new Render());

        Console.ReadLine();
    }
}