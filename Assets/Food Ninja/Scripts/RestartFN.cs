using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartFN : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene2();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadFN(0);
        }
    }
    public void LoadFN(int sceneANumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneANumber);
        SceneManager.LoadScene(sceneANumber);
    }
    public void ReloadScene2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
