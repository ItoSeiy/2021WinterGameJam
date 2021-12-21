using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : ItemBase, IItem
{
    public ItemID ID { get => ItemID.Star; }
    public int Score { get => 4; }
}
