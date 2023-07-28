using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSB : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadSB();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadSB(0);
        }
    }
    public void LoadSB(int sceneANumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneANumber);
        SceneManager.LoadScene(sceneANumber);
    }
    public void ReloadSB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
