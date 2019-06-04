using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MYCLASSNAME : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void choosemenu()
    {
        SceneManager.LoadScene(2);
    }

    public void firstto10()
    {
        SceneManager.LoadScene(3);
    }
}
