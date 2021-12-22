using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultTree : MonoBehaviour
{
    [SerializeField] GameObject[] items = default;
    [SerializeField] int[] itemID;
    [SerializeField] float SpawnXmin;
    [SerializeField] float SpawnXmax;
    [SerializeField] float SpawnYmin;
    [SerializeField] float SpawnYmax;
    //List<int> itemID = GameObject.Find("GameManager").GetComponent<GameManager>().ItemId;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var go in itemID)
        {
            Instantiate(items[go],new Vector3(Random.Range(SpawnXmin,SpawnXmax), Random.Range(SpawnYmin,SpawnYmax),0), Quaternion.identity);
            var _rb = items[go].GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }
}
