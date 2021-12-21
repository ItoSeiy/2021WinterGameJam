using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance => _instance;
    private  static TimeManager _instance;

    public float GameTimer { get => _gameTimer; }
    public bool IsFeverTime { get => _isFeverTime; }

    [SerializeField] private TextMeshProUGUI _timeText = null;
    [SerializeField] private float _gameTimer = 60f;
    [SerializeField] private float _feverTime = 10f;
    private bool _isFeverTime = false;
    private void Awake()
    {
        _instance = this;
    }
    private void Update()
    {
        if (!GameManager.Instance.IsStart) return;
        _gameTimer -= Time.deltaTime;
        _timeText.text = _gameTimer.ToString("F0");

        if(_gameTimer <= _feverTime)
        {
            _isFeverTime = true;
        }

        if(_gameTimer <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
