using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : ItemBase, IItem
{
    public ItemID ID => ItemID.Star;
    public int Score => 4;
}
