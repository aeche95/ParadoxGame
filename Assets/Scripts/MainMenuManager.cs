using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnSettingsButtonPressed()
    {
        Debug.Log("Settings button pressed");
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
