using System.Collections;
using UnityEngine;

//Example of Inheritance
public class Cube : Shape
{
    Animator anim;
    bool dancing;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    protected override void HandleShapeClicked() //Example of Polymorphism
    {
        if (!dancing)
        {
            StartCoroutine("DanceAndChangeColor");
        }
    }

    IEnumerator DanceAndChangeColor()
    {
        dancing = true;
        anim.ResetTrigger("AnimTrig");
        ChangeColor(CustomColor);
        anim.SetTrigger("AnimTrig");
        yield return new WaitForSeconds(1.1f);
        ChangeColor(DefaultColor);
        dancing = false;
    }
}