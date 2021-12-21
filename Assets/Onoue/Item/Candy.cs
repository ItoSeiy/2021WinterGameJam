using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : ItemBase, IItem
{
    public ItemID ID => ItemID.Candy;

    public int Score => 2;
}
