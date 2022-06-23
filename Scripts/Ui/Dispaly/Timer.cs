using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timer;

    private float _time;

    void Update()
    {
        _time = Time.time;

        _timer.text = ((int)_time).ToString();
    }
}
