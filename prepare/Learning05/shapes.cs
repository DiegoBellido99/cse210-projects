using System.Formats.Asn1;
using System.Globalization;

public  class Shapes
{
    private string _color;


    public Shapes(string color)
    {
       _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }


    public  virtual double  GetArea()
    {
        return 0;
    }
        
}