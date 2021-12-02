using UnityEngine;
using UnityEngine.SceneManagement;

public class StopPanelBtn : MonoBehaviour
{
    public GameObject stopPanel;


    public void LoadSampleScene ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit ()
    {
      Application.Quit();
    }

    public void GoToHome ()
    {
        SceneManager.LoadScene("Home");
    }

    public void Pause()
    {
        stopPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        stopPanel.SetActive(false);
        Time.timeScale = 1;
    }

}
