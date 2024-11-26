using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Replace "YourSceneName" with the name of the scene you want to load
        SceneManager.LoadScene("Hospital_Level");
    }
}
