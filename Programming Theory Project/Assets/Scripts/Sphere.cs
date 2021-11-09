using UnityEngine;

public class Sphere : Shape
{
    public override void HandleShapeClicked()
    {
        Debug.Log("Hi! my name is " + Name + ". My assigned color is: " + this.Color.ToString());

        ChangeShapeColor(this.Color);
    }
}