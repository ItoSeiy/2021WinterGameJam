using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ribbon : ItemBase, IItem
{
    public ItemID ID => ItemID.Ribbon;

    public int Score => 3;
}
