using System.Collections;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Vector3 startPosition;
    private bool isDragging = false;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        startPosition = transform.position;
    }

    void OnMouseDown()
    {
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;

        // Check if dropped inside a bin
        Collider[] hits = Physics.OverlapSphere(transform.position, 0.5f);
        foreach (Collider hit in hits)
        {
            Bin bin = hit.GetComponent<Bin>();
            if (bin != null)
            {
                if (bin.binType == this.tag)
                {
                    bin.AcceptTrash(this.gameObject);
                    return;
                }
            }
        }

        // If wrong bin or no bin hit → reset position
        transform.position = startPosition;
    }

    void Update()
    {
        if (isDragging)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Plane plane = new Plane(Vector3.up, 0);
            if (plane.Raycast(ray, out float distance))
            {
                transform.position = ray.GetPoint(distance);
            }
        }
    }
}
