using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    //Changes to room (1st scene)
    public void Play()
    {
        SceneManager.LoadScene("Room");
    }

    //Closes game
    public void Exit()
    {
        Application.Quit();
    }
}
