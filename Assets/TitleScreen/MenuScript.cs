using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Bedroom");
    }
    public void OptionsMenu()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
