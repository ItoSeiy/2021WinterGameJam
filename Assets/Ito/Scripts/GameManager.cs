using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance => _instance;
    private static GameManager _instance;


    public List<int> ItemId { get => _itemId;}
    public int Score { get => _score; }
    public bool IsStart { get => _isStart; }

    private List<int> _itemId = new List<int>();
    private int _score = default;
    private bool _isStart = false;

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void GameStart()
    {
        _isStart = true;
        _score = 0;
    }

    public void GameOver()
    {
        _isStart = false;
    }

    /// <summary>
    /// クリスマスツリーに飾り付けるアイテムをゲットした時に呼び出す関数
    /// </summary>
    /// <param name="score"></param>
    /// <param name="itemId"></param>
    public void GetItem(int score, int itemId)
    {
        _itemId.Add(itemId);
        _score += score;
    }

    /// <summary>
    /// クリスマスツリーに飾らないアイテムをゲットした時に呼び出す関数
    /// </summary>
    /// <param name="score">スコア(負の数)</param>
    public void GetItem(int score)
    {
        _score += score;
    }
}
