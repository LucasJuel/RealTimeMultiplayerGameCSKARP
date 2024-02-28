using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{

    public Material green;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit: " + hit.collider.gameObject.name);
                Material currentMat = hit.collider.gameObject.GetComponent<Renderer>().material;
                hit.collider.gameObject.GetComponent<Renderer>().material.color = currentMat.color - new Color(0, 0, 0, 255);
        }
        }
    }
}
