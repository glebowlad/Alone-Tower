using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIToolkitManager : MonoBehaviour
{
    [SerializeField] UIDocument uiDocument;
    [SerializeField] VisualElement root;

    void Start()
    {
        root= uiDocument.rootVisualElement;
        var playButton = root.Q<VisualElement>("PlayButton");
        playButton.RegisterCallback<ClickEvent>(PlayGame);

        var settingsButton = root.Q<VisualElement>("SettingsButton");
        settingsButton.RegisterCallback<ClickEvent>(GoToSettngs);
        
        var exitButton = root.Q<VisualElement>("ExitButton");
        exitButton.RegisterCallback<ClickEvent>(ExitGame);

       
    }

    private void ExitGame(ClickEvent evt)
    {
        Debug.Log("Quit game");
        Application.Quit();
    }

    private void GoToSettngs(ClickEvent evt)
    {
        Debug.Log("Go to Settings");
    }

    private void PlayGame(ClickEvent evt)
    {
        SceneManager.LoadScene(1);
        var mainPanel = root.Q<VisualElement>("MainPanel");
        mainPanel.style.display= DisplayStyle.None;
      

    }
}
