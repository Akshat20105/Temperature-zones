using UnityEngine;
using UnityEngine.UI;

public class ToggleGameObjects : MonoBehaviour
{
    public GameObject[] targetGameObjects;

    private void Start()
    {
        // Ensure the targetGameObjects are initially set to the desired active state
        foreach (GameObject target in targetGameObjects)
        {
            target.SetActive(false);
        }
    }

    public void ToggleActiveStates()
    {
        // Toggle the active state of each targetGameObject
        foreach (GameObject target in targetGameObjects)
        {
            target.SetActive(!target.activeSelf);
        }
    }
}

