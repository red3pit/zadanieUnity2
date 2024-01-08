using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScenes : MonoBehaviour
{
    public int numberOfCopies = 3;
    public string sceneName;
    public GameObject loadingScreen;
    public Slider loadingBar;

    public void LoadButton()
    {
        loadingScreen.SetActive(true);
        StartCoroutine(LoadScenes(sceneName));
    }

    IEnumerator LoadScenes(string sceneName)
    {
        int loadedScenesCount = 0;

        while (loadedScenesCount < numberOfCopies)
        {
            AsyncOperation loadOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

            while (!loadOperation.isDone)
            {
                float progressValue = Mathf.Lerp(loadingBar.value, (float)loadedScenesCount / numberOfCopies, Time.deltaTime * 5f);
                loadingBar.value = progressValue;
                yield return null;
            }

            loadedScenesCount++;
        }
        loadingScreen.SetActive(false);
    }

}
