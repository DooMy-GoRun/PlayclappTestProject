using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    [SerializeField] private InputField _inputSpeed;
    [SerializeField] private InputField _inputDistance;
    [SerializeField] private InputField _inputTimeSpawn;

    void Update()
    {
        if (_inputSpeed.text == "-")
        {
            _inputSpeed.text = string.Empty;
            return;
        }

        if (_inputDistance.text == "-")
        {
            _inputDistance.text = string.Empty;
            return;
        }

        if (_inputTimeSpawn.text == "-")
        {
            _inputTimeSpawn.text = string.Empty;
            return;
        }
    }

    public float InputSpeed() =>  float.Parse(_inputSpeed.text) / 2000;
    public float InputDistance() => float.Parse(_inputDistance.text);
    public float InputTimeSpawn() => float.Parse(_inputTimeSpawn.text);

    public bool CheckAllInputText()
    {
        return (_inputSpeed.text != string.Empty && _inputDistance.text != string.Empty && _inputTimeSpawn.text != string.Empty);
    }
}
