using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeTheSceneNow(string message)
    {
        int indx = int.Parse(message);
        Debug.Log("Let's change scene to: " + indx);
        SceneManager.LoadScene(indx, LoadSceneMode.Single);
    }
}
