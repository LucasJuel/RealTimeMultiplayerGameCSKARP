using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OnStartup : MonoBehaviour
{   
    public GameObject obj;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // Create a new instance of the object
        float x = obj.transform.position.x;
        float y = obj.transform.position.y;
    }

    // Update is called once per frame
    void Update(){
        float x = obj.transform.position.x;
        obj.transform.position = new Vector3(x + speed, 0, 0);
        
    }
}
