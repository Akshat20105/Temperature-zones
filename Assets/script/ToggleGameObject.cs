using UnityEngine;
using UnityEngine.UI;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject targetGameObject;

    private void Start()
    {
        // Ensure the targetGameObject is initially set to the desired active state
        targetGameObject.SetActive(false);
    }

    public void ToggleActiveState()
    {
        // Toggle the active state of the targetGameObject
        targetGameObject.SetActive(!targetGameObject.activeSelf);
    }
}
