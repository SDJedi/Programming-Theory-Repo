//Example of Inheritance
public class Sphere : Shape
{
    protected override void HandleShapeClicked() //Example of Polymorphism
    {
        ToggleColor();
    }
}