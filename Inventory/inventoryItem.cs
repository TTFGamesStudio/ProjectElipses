using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "data/item", order = 0)]
public class inventoryItem : ScriptableObject
{
    public string itemName;
    public Sprite image;
    public string description;

    public bool stackable;
    public bool usable;
    public bool equippable;
    public bool discardable;
}
