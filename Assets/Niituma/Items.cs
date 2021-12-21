using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] float _desPosY = -5;
    [SerializeField] int _score = 10;
    public enum ItemId
    {
        Id,
        Id2,
        Id3,
        Id4,
        Id5
    }
    [SerializeField] ItemId ID;
    public int IDs{ get => (int)ID; }
    public int Score{ get => _score; }

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
            Destroy(this.gameObject);
        }
    }
}
