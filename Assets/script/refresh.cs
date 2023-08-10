using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class refresh : MonoBehaviour
{
    
    // Update is called once per frame
    public void Refresh()
    {
        SceneManager.LoadScene(0);
    }
}
