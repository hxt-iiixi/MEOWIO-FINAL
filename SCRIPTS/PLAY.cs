using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(sceneName: "LEVELS");
    }
    public void Costumize()
    {
        SceneManager.LoadSceneAsync(sceneName: "COSTUMIZE");
    }
    public void Settings()
    {
        SceneManager.LoadSceneAsync(sceneName: "SETTINGS");
    }
    public void Back()
    {
        SceneManager.LoadSceneAsync(sceneName: "MAIN");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
