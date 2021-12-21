using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] _items = default;
    [SerializeField] float _generateSpeed = 2f;
    [SerializeField] float _generateTime = 3f;
    float _time = 0;

    // Update is called once per frame
    void Update()
    {
        _time += _generateSpeed * Time.deltaTime;
        if (_time > _generateTime)
        {
            _time = 0;
            Instantiate(_items[Random.Range(0,_items.Length)], this.transform.position + new Vector3(Random.Range(-8,8),0,0), Quaternion.identity);
        }
    }
}
