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
        Vector2 velocity = new Vector2(h,0) * _moveSpeed;
        _rb.velocity = velocity;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gm.GetItem(collision.gameObject.name);
    }
}
