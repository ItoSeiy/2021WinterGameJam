using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : ItemBase, IItem
{
    public ItemID ID => ItemID.Ball;

    public int Score => 1;
}
