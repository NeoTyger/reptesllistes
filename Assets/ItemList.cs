using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{

    public List<Item> itemList = new List<Item>();

    public Item[] itemArray = new Item[5];

    // Start is called before the first frame update
    void Start()
    {
        itemArray[0] = new Item("Uno", "111AAA", "Joc de cartes");
        itemArray[1] = new Item("Monopoly", "222BBB", "Joc de taula");
        itemArray[2] = new Item("Risk", "333CCC", "Joc de taula");
        itemArray[3] = new Item("Virus", "444DDD", "Joc de cartes");
        itemArray[4] = new Item("Parchis", "555EEE", "Joc de taula");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddItem();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RemoveItem();
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in itemList)
            {
                Debug.Log(item.GetItemName());
            }
        }
    }

    public void AddItem()
    {
        var itemRandom = itemArray[Random.Range(0, itemArray.Length)];

        itemList.Add(itemRandom);
        
        Debug.Log(itemRandom.GetItemName() + " added");
    }
    
    public void RemoveItem()
    {
        var itemRandom = itemArray[Random.Range(0, itemArray.Length)];

        var deleted = itemList.Remove(itemRandom);

        if (deleted == false)
        {
            Debug.Log("Es item " + itemRandom.GetItemName() + " no existeix dins sa llista");
        }
        else
        {
            Debug.Log(itemRandom.GetItemName() + " deleted");
        }
    }
}
