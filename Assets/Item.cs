using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    [SerializeField] protected string itemName;
    [SerializeField] protected string id;
    [SerializeField] protected string description;


    public Item(string itemName, string id, string description)
    {
            
        //Initialize things here
        this.itemName = itemName;
        this.id = id;
        this.description = description;
            
    }

    public string GetItemName()
    {
        return itemName;
    }

    public virtual void MyTreat()
    {
        Debug.Log("Som un item general, no tenc característica especial");
    }
}
