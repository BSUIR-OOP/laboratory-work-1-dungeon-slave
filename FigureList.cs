class FiguresList
{
    private Dot[] FiguresArray = new Dot[6];
    private int pos = 0;

    public void AddFigureToList(Dot Figure)
    {
        FiguresArray[pos] = Figure;
        pos++;
    }
    public void PrintFigures(Render Rn)
    {
        while(pos > 0)
        {
            pos--;
            System.Console.WriteLine(Rn.FrameRendering(FiguresArray[pos].IsFigure));
        }
    }
}