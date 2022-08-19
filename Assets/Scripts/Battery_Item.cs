using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName ="New Item/item")]
public class Battery_Item : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public Sprite itemImage;
    public GameObject itemPrefab;

    public string GetItemType;

    public enum ItemType
    {
        GetHP,
        Neccesary
    }

   
}
