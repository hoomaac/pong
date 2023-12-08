using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject m_mainMenu;

    [SerializeField] private Button m_playButton;
    [SerializeField] private Button m_exitButton;
    [SerializeField] private Button m_backButton;

    private void Start()
    {
        m_mainMenu.SetActive(true);
        m_playButton.onClick.AddListener(PlayButtonOnClick);
        m_exitButton.onClick.AddListener(() => {Debug.Log("Quit"); Application.Quit(); });
        m_backButton.onClick.AddListener(BackButtonOnClick);
    }

    private void PlayButtonOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void BackButtonOnClick()
    {
        m_mainMenu.SetActive(true);
    }
}
