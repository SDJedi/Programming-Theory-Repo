using UnityEngine;
//Goal: Demonstrate understanding of the pillars of OOP: 
//Abstraction, Inheritance, Polymorphism, and Encapsulation

//Shape is the base class from which specific shape classes are derrived.
//includes methods to change the shape's color, and to toggle between custom and default colors.
//Update() monitors for user clicks; each child class must define for itself what happens when clicked.
public abstract class Shape : MonoBehaviour
{
    [SerializeField] Color customColor; //assign in inspector

    MeshRenderer meshRenderer;
    Color defaultColor; //example of using Encapsulation to protect data | accessible through a getter

    public Color CustomColor { get { return customColor; } }
    public Color DefaultColor { get { return defaultColor; } }


    void Awake()
    {
        //initialize variables
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        defaultColor = meshRenderer.materials[0].color;
    }

    protected virtual void Update()
    {
        CheckForUserInput(); //example of Abstraction
    }

    //look for left-clicks and call HandleShapeClicked() if this.gameObject was clicked
    void CheckForUserInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == gameObject)
                {
                    HandleShapeClicked();
                }
            }
        }
    }

    protected void ChangeColor(Color color)
    {
        meshRenderer.materials[0].color = color;
    }

    protected void ToggleColor()
    {
        if (meshRenderer.materials[0].color == CustomColor)
        {
            ChangeColor(defaultColor);
        }
        else
        {
            ChangeColor(CustomColor);
        }
    }

    protected abstract void HandleShapeClicked();
}