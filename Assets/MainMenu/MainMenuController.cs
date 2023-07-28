using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // This function is called when any of the buttons is clicked
    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
        public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}