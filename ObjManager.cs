using UnityEngine;
using UnityEngine.UI;

public class ObjManager : MonoBehaviour
{
    public GameObject[] panels; // ������ �������
    private bool panelsActive = false;

    void Start()
    {
        // �������� ��� ������ ��� �������
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
