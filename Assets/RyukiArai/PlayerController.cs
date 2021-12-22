using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator _animator;
    [SerializeField] float _moveSpeed;
    public AudioClip getSound;
    public AudioClip BombSound;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _audioSource = gameObject.GetComponent<AudioSource>();
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector2 velocity = new Vector2(h,0) * _moveSpeed;
        _rb.velocity = velocity;
        _animator.SetFloat("Speed", h);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var obj = collision.gameObject.GetComponent<ItemBase>();
        switch (collision.gameObject.tag)
        {
            case "Item":
                GameManager.Instance.GetItem(obj.Score, (int)obj.ID);
                Debug.Log("Collision Item");
                Destroy(collision.gameObject);
                _audioSource.PlayOneShot(getSound);
                break;
            case "Bomb":
                GameManager.Instance.GetItem(obj.Score);
                Debug.Log("Collision Bomb");
                Destroy(collision.gameObject);
                _audioSource.PlayOneShot(BombSound);
                break;
        }
    }
}
