using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartNature : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene1();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadNature(0);
        }
    }
    public void LoadNature(int sceneANumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneANumber);
        SceneManager.LoadScene(sceneANumber);
    }
    public void ReloadScene1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
