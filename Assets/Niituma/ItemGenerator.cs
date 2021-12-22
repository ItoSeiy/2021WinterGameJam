using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] _items = default;
    [SerializeField] float _generateSpeed = 2f;
    [SerializeField] float _feverGenerateTime = 1f;
    [SerializeField] float _normalGenerateTime = 3f;
    float _time = 0;

    // Update is called once per frame
    void Update()
    {
        float GenerateTime = TimeManager.Instance.IsFeverTime ? _feverGenerateTime : _normalGenerateTime;
        _time += _generateSpeed * Time.deltaTime;
        if (_time > GenerateTime)
        {
            _time = 0;
            Instantiate(_items[Random.Range(0,_items.Length)], this.transform.position + new Vector3(Random.Range(-5,5),0,0), Quaternion.identity);
        }
    }
}
