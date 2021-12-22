using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText = null;
    [SerializeField] TextMeshProUGUI _gameTimer = null;
    // Start is called before the first frame update
    void Update()
    {
        _scoreText.text = "Score:"+ GameManager.Instance.Score.ToString("0000");

        _gameTimer.text = "Time:" + TimeManager.Instance.GameTimer.ToString("F0");
    }
}
