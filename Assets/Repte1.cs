using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repte1 : MonoBehaviour
{

    public List<string> nameList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        nameList.Add("Grayson");
        nameList.Add("Todd");
        nameList.Add("Drake");
        nameList.Add("Wayne");
        nameList.Add("Ace");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var name in nameList)
            {
                Debug.Log(name);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            int index = Random.Range(0,nameList.Count);
            Debug.Log(nameList[index] + " Borrado");
            nameList.RemoveAt(index);

            if (nameList.Count <= 0)
            {
                Debug.Log("WARNING, no items in that list!");
            }
        }
    }
}
