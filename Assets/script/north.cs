using UnityEngine;
using UnityEngine.SceneManagement;

public class north : MonoBehaviour
{
    // public string sceneName; // Name of the scene to open

    // Called when the game object's collider is clicked (OnMouseDown event)
    void OnMouseDown()
    {
        // Load the specified scene
        SceneManager.LoadScene(2);
    }
}
