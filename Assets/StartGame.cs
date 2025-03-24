using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("NextScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

