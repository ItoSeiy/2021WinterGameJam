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
//IDやスコアがほしいときはこのインターフェースをゲットコンポーネントする
public interface IItem
{
    ItemID ID { get; }
    int Score { get; }
}
