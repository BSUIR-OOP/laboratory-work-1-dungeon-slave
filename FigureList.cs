class FiguresList
{
    private List<Dot> FigList = new List<Dot>();

    public void AddToList(Dot Figure)
    {
        FigList.Add(Figure);
    }

    public void PrintList(Render Rn)
    {
        int i = 0;
        while(i < FigList.Count)
        {
            System.Console.WriteLine(Rn.FrameRendering(FigList[i].IsFigure));
            i++;
        }
    }
}
