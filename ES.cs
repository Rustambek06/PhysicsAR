using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ES : MonoBehaviour
{

    public Text data;
    public Text R;
    public Slider slider;

    private bool Click = false;
    private float Amperage; 

    private void Start()
    {
        ClickableScript.OnClicked += HandleClick;
        slider.onValueChanged.AddListener(OnSliderValueChanged);
        Amperage = slider.value;
    }

    private void OnSliderValueChanged(float value)
    {
        Amperage = value; // ����������� �������� Slider ���������� ���� float
    }

    // �����, ������� ����� ���������� ��� �������
    private void HandleClick()
    {
        Click = !Click;
    }

    private void OnDestroy()
    {
        ClickableScript.OnClicked -= HandleClick;
        Click = false;
    }

    private void Update()
    {
        float Voltage = 3.6f;
        float Resistance = Voltage / Amperage;

        if (Click)
        {
            data.text = string.Format("������� ��������\nI = U / R\n��������� ������ �������� � ���������� \n���� ������� ������������ R\n���������� U : {0}\n���� ���� � : {1}", Voltage, Amperage);
        }
        else
        {
            data.text = string.Format("������� ���������");
        }

        R.text = string.Format("�������� ������������� ����� {0}\nR = U / I = {1} / {2} = {3}", Resistance, Voltage, Amperage, Resistance);
    } 
}
