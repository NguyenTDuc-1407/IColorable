Circle circle = new Circle(5);
Rectangle rectangle1 = new Rectangle(3, 7);
Rectangle rectangle2 = new Rectangle(7, 9);
Shape[] shapes = new Shape[] { circle, rectangle1, rectangle2 };
foreach (Shape shape in shapes)
{
    if (shape is IColorable)
    {
        ((IColorable)shape).HowToColor();
    }
   Console.WriteLine(circle.getArea());
}