using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    public string targetSceneName1;
    public string targetSceneName2;
    public void GoToScreen1()
    {
        SceneManager.LoadScene(targetSceneName1); 
    }
        public void GoToScreen2()
    {
        SceneManager.LoadScene(targetSceneName2);
    }
}
