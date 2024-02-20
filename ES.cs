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
        Amperage = value; // Присваиваем значение Slider переменной типа float
    }

    // Метод, который будет вызываться при нажатии
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
            data.text = string.Format("Питание включено\nI = U / R\nПользуясь данной формулой и значениями \nниже найдите сопротвление R\nНапряжение U : {0}\nСила тока А : {1}", Voltage, Amperage);
        }
        else
        {
            data.text = string.Format("Питание отключено");
        }

        R.text = string.Format("Значение сопративления равна {0}\nR = U / I = {1} / {2} = {3}", Resistance, Voltage, Amperage, Resistance);
    } 
}
