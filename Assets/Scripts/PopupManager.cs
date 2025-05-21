using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupManager : MonoBehaviour
{
    public GameObject levelCompletePopup;
    public GameObject levelLostPopup;
    public CameraController cameraController;

    private void CenterPopup(GameObject popup)
    {
        RectTransform rectTransform = popup.GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.anchoredPosition = Vector2.zero;
        }
    }

    public void ShowLevelCompletePopup()
    {
        CenterPopup(levelCompletePopup);
        levelCompletePopup.SetActive(true);
        Time.timeScale = 0;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (cameraController != null)
            cameraController.enabled = false;
    }

    public void ShowLevelLostPopup()
    {
        CenterPopup(levelLostPopup);
        levelLostPopup.SetActive(true);
        Time.timeScale = 0;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (cameraController != null)
            cameraController.enabled = false;
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");

        if (cameraController != null)
            cameraController.enabled = true;
    }

    public void RetryLevel()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        if (cameraController != null)
            cameraController.enabled = true;
    }
}