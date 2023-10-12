abstract class Shape{
    public Color Color { get; set; }

    public Shape(Color color){
        Color = color;
    }

    //método abstrato
    public abstract double Area();
    
}