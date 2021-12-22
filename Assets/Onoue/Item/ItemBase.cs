using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemID
{
    Ball,
    Candy,
    Ribbon,
    Star,
    Bomb
}

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class ItemBase :MonoBehaviour
{
    [SerializeField]
    ItemID itemID;
    [SerializeField]
    int score;
    public ItemID ID { get=> itemID;}
    public int Score { get=> score;}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
