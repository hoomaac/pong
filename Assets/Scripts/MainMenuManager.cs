using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _playModeMenu;

    [SerializeField] private Button _playButton;
    [SerializeField] private Button _exitButton;

    #region Playe Mode Menu
    [SerializeField] private Button _computerButton;
    [SerializeField] private Button _hostButton;
    [SerializeField] private Button _joinButton;
    [SerializeField] private Button _backButton;
    #endregion

    private void Start()
    {
        _mainMenu.SetActive(true);
        _playModeMenu.SetActive(false);

        _playButton.onClick.AddListener(PlayButtonOnClick);
        _exitButton.onClick.AddListener(() =>
        {
            Debug.Log("Quit");
            Application.Quit();
        });
        _computerButton.onClick.AddListener(ComputerButtonOnClick);
        _hostButton.onClick.AddListener(HostButtonOnClick);
        _joinButton.onClick.AddListener(JoinButtonOnClick);
        _backButton.onClick.AddListener(BackButtonOnClick);
    }

    private void PlayButtonOnClick()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        _mainMenu.SetActive(false);
        _playModeMenu.SetActive(true);

    }

    private void ComputerButtonOnClick()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void HostButtonOnClick()
    {
        Debug.Log("Host button is pressed");
    }

    private void JoinButtonOnClick()
    {
        Debug.Log("Join button is pressed");
    }

    private void BackButtonOnClick()
    {
        _mainMenu.SetActive(true);
        _playModeMenu.SetActive(false);
    }

}
