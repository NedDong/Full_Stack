namespace HW3Color;

public class Ball
{
    public int size { get; set; }
    public Color color { get; set; }
    public int timesThrown { get; set; }

    public Ball(int size, Color color, int timesThrown)
    {
        this.size = size;
        this.color = color;
        this.timesThrown = timesThrown;
    }

    public void Pop()
    {
        this.size = 0;
    }

    public void Throw()
    {
        if (this.size != 0)
        {
            this.timesThrown++;
        }
    }

    public int getTimesThrown()
    {
        return this.timesThrown;
    }
}