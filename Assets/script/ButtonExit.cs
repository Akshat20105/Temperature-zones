using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    // Attach this script to the button's OnClick event in the Inspector.
    public void OnExitButtonClick()
    {
        // Quit the application (works for standalone builds)
        Application.Quit();

        // Note: Application.Quit() may not work in the Unity Editor.
        // In the Editor, you can use UnityEditor.EditorApplication.Exit(0) instead.
// #if UNITY_EDITOR
//         UnityEditor.EditorApplication.Exit(0);
// #endif
    }
}
