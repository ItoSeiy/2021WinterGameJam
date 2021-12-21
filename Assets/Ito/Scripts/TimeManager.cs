using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance => _instance;
    private  static TimeManager _instance;

    public float GameTimer { get => _gameTimer; }
    public bool IsFeverTime { get => _isFeverTime; }

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

        if(_gameTimer <= _feverTime)
        {
            _isFeverTime = true;
        }
    }
}
