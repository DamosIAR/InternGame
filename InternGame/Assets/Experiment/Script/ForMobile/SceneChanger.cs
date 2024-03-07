using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneChanger : MonoBehaviour
{
    public static SceneChanger instance;

    private void Awake()
    {
        instance = this;
    }
       
    public enum Scene
    {
        MainMenu,
        CrabSpearing,
        CookGame
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString());
    }
}
