using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    [SerializeField] private GameObject targetPanel;

    public void Close()
    {
        targetPanel.SetActive(false);
    }
}