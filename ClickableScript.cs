using UnityEngine;

public class ClickableScript : MonoBehaviour
{
    // �������, ������� ����� ���������� ��� �������
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    // ���������� ��� ����� �� ������
    private void OnMouseDown()  
    {
        if (OnClicked != null)
        {
            OnClicked();
        }
    }
}
