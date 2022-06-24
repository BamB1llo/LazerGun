using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timer;

    private float _time;
    private GameOverScreen _gameOver;

    private void OnEnable()
    {
        _gameOver.ResetTimer += ResetTimer;
    }

    private void OnDisable()
    {
        _gameOver.ResetTimer -= ResetTimer;
    }

    void Update()
    {
        _time = Time.timeSinceLevelLoad;

        _timer.text = ((int)_time).ToString();
    }

    private void ResetTimer(float ressetTimerValue)
    {
        _time = ressetTimerValue;
    }
}
