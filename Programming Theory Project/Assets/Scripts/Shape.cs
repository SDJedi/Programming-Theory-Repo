using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] string m_name;
    [SerializeField] Color m_color;

    public string Name { get { return m_name; } }
    public Color Color { get { return m_color; } }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == gameObject.transform)
                {
                    HandleShapeClicked();
                }
            }
        }
    }

    protected void ChangeShapeColor(Color color)
    {
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        if (mr != null)
        {
            mr.materials[0].color = color;
        }
    }

    public abstract void HandleShapeClicked();
}