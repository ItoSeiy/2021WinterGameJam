using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultTree : MonoBehaviour
{
    [SerializeField] GameObject[] items = default;

    List<int> itemID = GameObject.Find("GameManager").GetComponent<GameManager>().ItemId;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var go in itemID)
        {
            Instantiate(items[go],new Vector3(Random.Range(-10,10), Random.Range(5,10),0),transform.rotation.normalized);
        }
    }
}
