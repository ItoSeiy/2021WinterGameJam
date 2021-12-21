using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    GameManager _gm;
    [SerializeField] float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        _rb.AddForce(new Vector2(h * _moveSpeed,0));
        _rb.AddForce(Vector2.zero);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
