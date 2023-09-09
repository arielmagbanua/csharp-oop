public class DemoMethod
{
    public int something = 10;

    public DemoMethod()
    {
    }

    public void PrintSomething()
    {
        Console.WriteLine("Print!!!");
    }

    public void PrintRectArea(int width, int height)
    {
        int area = width * height;
        Console.WriteLine("The Area of Rectangle is " + area);
    }

    public int GetRectArea(int width, int height)
    {
        int area = width * height;
        return area;
    }
}
