using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject m_mainMenuCanvas;
    [SerializeField] private GameObject m_settingsMenuCanvas;
    [SerializeField] private GameObject m_keyboardControlsCanvas;

    [SerializeField] private GameObject m_mainMenuFirstSelected;
    [SerializeField] private GameObject m_settingsMenuFirstSelected;
    [SerializeField] private GameObject m_keyboardControlsSelected;

    private bool isPaused;

    private void Start()
    {
        m_mainMenuCanvas.SetActive(false);
        m_settingsMenuCanvas.SetActive(false);
        m_keyboardControlsCanvas.SetActive(false);
    }

    private void Update()
    {
        if (InputManager.Instance.MenuInput)
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }
    }
    private void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

        OpenMainMenu();
    }

    private void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1f;
        CloseMenus();
    }

    private void OpenMainMenu()
    {
        m_mainMenuCanvas.SetActive(true);
        m_settingsMenuCanvas.SetActive(false);
        m_keyboardControlsCanvas.SetActive(false);
        
        EventSystem.current.SetSelectedGameObject(m_mainMenuFirstSelected);
    }

    private void OpenSettingsMenu()
    {
        m_mainMenuCanvas.SetActive(false);
        m_settingsMenuCanvas.SetActive(true);
        m_keyboardControlsCanvas.SetActive(false);

        EventSystem.current.SetSelectedGameObject(m_settingsMenuFirstSelected);
    }

    private void OpenKeyboardControlsMenu()
    {
        m_mainMenuCanvas.SetActive(false);
        m_settingsMenuCanvas.SetActive(false);
        m_keyboardControlsCanvas.SetActive(true);

        EventSystem.current.SetSelectedGameObject(m_keyboardControlsSelected);
    }

    private void CloseMenus()
    {
        m_mainMenuCanvas.SetActive(false);
        m_settingsMenuCanvas.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
    }

    public void SettingsButtonOnClick()
    {
        OpenSettingsMenu();
    }

    public void KeyboardControlsOnClick()
    {
        OpenKeyboardControlsMenu();
    }

    public void ResumeButtonOnClick()
    {
        Unpause();
    }

    public void SettingsBackButtonOnClick()
    {
        OpenMainMenu();
    }

    public void KeyboardControlsBackButtonOnClick()
    {
        OpenSettingsMenu();
    }
}
