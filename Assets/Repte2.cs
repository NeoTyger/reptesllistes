using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repte2 : MonoBehaviour
{

    public GameObject[] elements = new GameObject[3];

    public List<GameObject> objectsCreated = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        elements[0] = GameObject.CreatePrimitive(PrimitiveType.Cube);
        elements[1] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        elements[2] = GameObject.CreatePrimitive(PrimitiveType.Capsule);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && objectsCreated.Count < 10)
        {
            var element = elements[Random.Range(0, elements.Length)];
            Vector3 position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
            GameObject obj = Instantiate(element, position, Quaternion.identity);
            
            objectsCreated.Add(obj);

            if (objectsCreated.Count == 10)
            {
                foreach (var objecte in objectsCreated)
                {
                    objecte.GetComponent<Renderer>().material.color = Color.green;
                }
            }
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (var objecte in objectsCreated)
            {
                Destroy(objecte);
            }
            
            objectsCreated.Clear();
        }
    }
}
