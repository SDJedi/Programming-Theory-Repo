using System.Collections;
using UnityEngine;

public class Cube : Shape
{
    Animator anim;
    bool dancing;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public override void HandleShapeClicked()
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
        ChangeShapeColor(this.Color);
        anim.SetTrigger("AnimTrig");
        yield return new WaitForSeconds(1.1f);
        ChangeShapeColor(Color.white);
        dancing = false;
    }
}