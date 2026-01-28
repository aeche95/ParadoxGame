using System.Collections;
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
        StartCoroutine(ChangeSceneCorroutine());
    }

    public void OnSettingsButtonPressed()
    {
        Debug.Log("Settings button pressed");
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

    public IEnumerator ChangeSceneCorroutine()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level1");
    }
}
