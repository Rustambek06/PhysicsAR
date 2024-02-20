using UnityEngine;

public class ClickableScript : MonoBehaviour
{
    // Событие, которое будет вызываться при нажатии
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    // Вызывается при клике на объект
    private void OnMouseDown()  
    {
        if (OnClicked != null)
        {
            OnClicked();
        }
    }
}
