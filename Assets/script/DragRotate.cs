using UnityEngine;

public class DragRotate : MonoBehaviour
{
    private Vector3 initialMousePosition;
    private bool isDragging = false;

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject == gameObject)
            {
                isDragging = true;
                initialMousePosition = Input.mousePosition - transform.position;
            }
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            // Calculate the new rotation based on the mouse movement
            Vector3 currentMousePosition = Input.mousePosition - initialMousePosition;
            float angle = Mathf.Atan2(currentMousePosition.x, currentMousePosition.y) * Mathf.Rad2Deg;

            // Apply the rotation
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
    }
}
