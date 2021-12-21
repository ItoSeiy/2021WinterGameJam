using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ItemBase, IItem
{
    public ItemID ID => ItemID.Bomb;
    public int Score => -1;
}
