using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    /*
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(canvasMain);
    }*/

    //____________________________________Menu Buttons____________________________________

    public void StartSP()
    {
        SceneManager.LoadScene("001_Jenga");
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("000_MainMenu");
    }



}
