using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    [SerializeField] private InputField _inputSpeed;
    [SerializeField] private InputField _inputDistance;
    [SerializeField] private InputField _inputTimeSpawn;
    [Space(10)]
    [SerializeField] private float _inputSpeedDivider = 2000;

    private const string Minus = "-";

    void Update()
    {
        ValidateTextToMinus(_inputSpeed.text);
        ValidateTextToMinus(_inputDistance.text);
        ValidateTextToMinus(_inputTimeSpawn.text);
    }

    public float InputSpeed() =>  float.Parse(_inputSpeed.text) / _inputSpeedDivider;
    public float InputDistance() => float.Parse(_inputDistance.text);
    public float InputTimeSpawn() => float.Parse(_inputTimeSpawn.text);

    public bool CheckAllInputText()
    {
        return (_inputSpeed.text != string.Empty && _inputDistance.text != string.Empty && _inputTimeSpawn.text != string.Empty);
    }

    private void ValidateTextToMinus(string text)
    {
        if (text == Minus)
        {
            text = string.Empty;
            return;
        }
    }
}
