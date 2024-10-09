namespace HW3Color;

public class Color
{
    private int r { get; set; }
    private int g { get; set; }
    private int b { get; set; }
    private int a { get; set; }
    
    public Color(int r, int g, int b, int a)
    {
        this.r = r;
        this.g = g;
        this.b = b;
        this.a = a;
    }
    
    
    public Color(int r, int g, int b)
    {
        this.r = r;
        this.g = g;
        this.b = b;
        this.a = 255;
    }

    public int getGreyScale()
    {
        return (r+g+b)/3;
    }
}