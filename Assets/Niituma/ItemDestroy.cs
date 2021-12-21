using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    [SerializeField] float _desPosY = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= _desPosY)
        {
            Destroy(this.gameObject);
        }
    }
}
