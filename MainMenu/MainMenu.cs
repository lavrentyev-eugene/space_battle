using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject MainScreen;
    public GameObject SettingsScreen;
    
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        MainScreen.SetActive(false);
        SettingsScreen.SetActive(true);
    }
    public void Return()
    {
        SettingsScreen.SetActive(false);
        MainScreen.SetActive(true);
    }
    public void AudioToggle()
    {
        AudioListener.pause = !AudioListener.pause;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
