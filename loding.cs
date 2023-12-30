using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;



public class Loading : MonoBehaviour
{  
    public GameObject lodingscreen;
    public Slider LodingBar;
    public void LoadScreen(int levelIndex)
    {
        StartCoroutine(LoadSceneAsynchronously(levelIndex));
    }

    IEnumerator LoadSceneAsynchronously(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        lodingscreen.SetActive(true);
        while (!operation.isDone)
        {
            LodingBar.value = operation.progress;
            yield return null;
        }
    }
}
