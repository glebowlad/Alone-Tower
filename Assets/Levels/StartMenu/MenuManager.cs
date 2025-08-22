using System.Collections;
using System.Collections.Generic;
using UnityEditor.AdaptivePerformance.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private GameObject MenuPanel;

    private void Awake()
    {
        MenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToSettings()
    {
        MenuPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }
    public void ExitSettings()
    {
        MenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
