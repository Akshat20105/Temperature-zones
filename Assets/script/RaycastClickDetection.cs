using UnityEngine;

public class RaycastClickDetection : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the ray hit a GameObject
                GameObject clickedObject = hit.collider.gameObject;
                Debug.Log("Clicked on " + clickedObject.name);

                // Add your custom logic here to handle the click on the GameObject
            }
        }
    }
}
