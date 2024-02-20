using UnityEngine;
using UnityEngine.UI;

public class ObjManager : MonoBehaviour
{
    public GameObject[] panels; // Массив панелей
    private bool panelsActive = false;

    void Start()
    {
        // Скрываем все панели при запуске
        SetPanelsActive(false);
    }

    public void TogglePanels()
    {
        panelsActive = !panelsActive;
        SetPanelsActive(panelsActive);
    }

    private void SetPanelsActive(bool active)
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(active);
        }
    }
}
