using UnityEngine;

//Example of Inheritance
public class Cylinder : Shape
{
    bool isRotating;


    protected override void Update()//Example of Polymorphism
    {
        base.Update();
        if (isRotating)
        {
            transform.Rotate(0, 0, -0.5f, Space.World);
        }
    }

    protected override void HandleShapeClicked() //Example of Polymorphism
    {
        isRotating = (!isRotating);
        ToggleColor();
    }
}