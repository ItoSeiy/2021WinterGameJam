using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance => _instance;


    static GameManager _instance;
    public List<string> ItemId { get => _itemId;}



    private List<string> _itemId = new List<string>();
   

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void GameStart()
    {

    }

    public void GetItem(string itemId)
    {
        _itemId.Add(itemId);

    }


}
