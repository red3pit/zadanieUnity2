using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScenes : MonoBehaviour
{
    public int numberOfCopies = 3;
    public string sceneName;

    public void LoadScene()
    {
        for (int i = 0; i < numberOfCopies; i++)
        {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }
    }
}
