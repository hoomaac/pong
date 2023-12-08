using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;

    [SerializeField] private Button _playButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _backButton;

    private void Start()
    {
        _mainMenu.SetActive(true);
        _playButton.onClick.AddListener(PlayButtonOnClick);
        _exitButton.onClick.AddListener(() =>
        {
            Debug.Log("Quit");
            Application.Quit();
        });
        _backButton.onClick.AddListener(BackButtonOnClick);
    }

    private void PlayButtonOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void BackButtonOnClick()
    {
        _mainMenu.SetActive(true);
    }
}
