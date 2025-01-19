using UnityEngine;

public class FinishZone : MonoBehaviour
{
    public PopupManager popupManager;
    public Transform cameraTransform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().enabled = false;

            RectTransform rectTransform = popupManager.levelCompletePopup.GetComponent<RectTransform>();
            if (rectTransform != null)
            {
                rectTransform.anchoredPosition = Vector2.zero;
            }

            popupManager.ShowLevelCompletePopup();
        }
    }
}