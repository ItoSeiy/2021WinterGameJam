using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance => _instance;
    static GameManager _instance;


    public List<int> ItemId { get => _itemId;}
    public int Score { get => _score; }

    private List<int> _itemId = new List<int>();
    private int _score = default;

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void GameStart()
    {
        _score = 0;
    }

    public void GetItem(int itemId, int score)
    {
        _itemId.Add(itemId);
        _score += score;
    }

    
}
