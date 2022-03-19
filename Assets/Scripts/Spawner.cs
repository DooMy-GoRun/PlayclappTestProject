using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private InputFieldManager _inputText;
    [SerializeField] private GameObject _cubePrefab;

    private float _timer;

    private void Start()
    {
        _timer = _inputText.InputTimeSpawn();
    }

    void Update()
    {
        _timer -= Time.deltaTime;

        if (_inputText.CheckAllInputText())
        {
            if (_timer <= 0)
            {
                var cloneCube = Instantiate(_cubePrefab, Vector3.zero, Quaternion.identity);
                cloneCube.SetActive(true);

                _timer = _inputText.InputTimeSpawn();
            }
        }
    }
}
