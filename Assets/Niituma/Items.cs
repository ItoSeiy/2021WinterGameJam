using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] float _desPosY = -5;
    [SerializeField] int _score = 10;
    [SerializeField] int _id = 0;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //FindObjectOfType<GameManager>().GetItem(_id,_score);
            Destroy(this.gameObject);
        }
    }
}
