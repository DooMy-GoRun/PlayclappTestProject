using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private InputFieldManager _inputText;

    private Transform _cube;

    private float _distance;
    private float _speed;

    private Vector3 _startPositionCube;
    private Vector3 _endPositionCube;
    private float _pathPercentage;

    private const float FullPathPercentage = 1;

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
        if (_pathPercentage > FullPathPercentage)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            return;
        }

        _pathPercentage += _speed;
        _cube.position = Vector3.Lerp(_startPositionCube, _endPositionCube, _pathPercentage);

        if (_speed == 0)
        {
            Destroy(gameObject, 2f);
        }
    }
}
