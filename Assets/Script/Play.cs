using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.AccessControl;

public class Play : MonoBehaviour
{
    public void PlayGame()
    {


         SceneManager.LoadScene("2");
     
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
