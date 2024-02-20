using UnityEngine;
using UnityEngine.UI;

public class ExperimentController : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject chutePrefab;

    public InputField Angle;
    public Button StartButton;
    public Text data;
    public Text Acc;

    private float chuteAngle = 0f;
    private float startTime;
    float elapsedTime = 0f;

    private GameObject ballInstance;
    private GameObject chuteInstance;

    public void CreateExperiment()
    {
        if (ballInstance != null && chuteInstance != null)
        {
            Destroy(ballInstance);
            Destroy(chuteInstance);
        }
        Accellerator();
        chuteInstance = Instantiate(chutePrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 0f, chuteAngle));
        ballInstance = Instantiate(ballPrefab, new Vector3(1.631f, 0.352f, 0f), Quaternion.identity);

        startTime = Time.time;
    }

    private void Accellerator()
    {
        if (float.TryParse(Angle.text, out float inputAngle))
        {
            chuteAngle = Mathf.Clamp(inputAngle, 1f, 5f);
        }
    }

    private float CalculateAcc(float time)
    {
        return 2 / (time * time);
    }

    public void DisplayData()
    {

        if (ballInstance.transform.position.x > -1.7)
        {
            elapsedTime = Time.time - startTime;
        }
        else
        {
            float Acceleration = CalculateAcc(elapsedTime);
            Acc.text = string.Format("Ускорение : {0} м/c^2", Acceleration);
        }

        data.text = string.Format("Длина l : 1 метр\nВремя : {0} секунд", elapsedTime);
    }

    void Update()
    {
        DisplayData();
    }
}
