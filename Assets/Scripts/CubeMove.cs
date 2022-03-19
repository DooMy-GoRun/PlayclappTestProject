using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private InputFieldManager _inputText;

    private Transform _cube;

    private float _distance;
    private float _speed;

    private Vector3 _startPositionCube;
    private Vector3 _endPositionCube;
    private float _pathPrecentage;

    private void Awake()
    {
        _cube = GetComponent<Transform>();

    }

    private void Start()
    {
        _distance = _inputText.InputDistance();
        _speed = _inputText.InputSpeed();

        _startPositionCube = _cube.position;
        _endPositionCube = _cube.position + new Vector3(0, 0, _distance);
    }

    private void FixedUpdate()
    {
        if (_pathPrecentage > 1)
        {
            Destroy(gameObject);
            return;
        }

        _pathPrecentage += _speed;
        _cube.position = Vector3.Lerp(_startPositionCube, _endPositionCube, _pathPrecentage);

        if (_speed == 0)
            Destroy(gameObject, 2f);
    }
}
