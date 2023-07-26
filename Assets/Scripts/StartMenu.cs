using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        int scenesNumber = SceneManager.sceneCountInBuildSettings;
        int nextSceneIndex = (SceneManager.GetActiveScene().buildIndex + 1) % scenesNumber;

        MainManager.Instance.cherries = 0;

        SceneManager.LoadScene(nextSceneIndex);
    }
}
