using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeTheSceneNow(string message)
    {
        int indx = int.Parse(message);
        Debug.Log("Let's change scene to: " + indx);

        try
        {
            LoaderUtility.Deinitialize();
        }
        catch { }


        SceneManager.LoadScene(indx, LoadSceneMode.Single);


        try {
            LoaderUtility.Initialize();
           } catch { }
       

        //var xrManagerSettings = UnityEngine.XR.Management.XRGeneralSettings.Instance.Manager;
        //xrManagerSettings.DeinitializeLoader();
        //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex); // reload current scene
        //xrManagerSettings.InitializeLoaderSync();
    }
}
