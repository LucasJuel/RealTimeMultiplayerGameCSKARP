using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public Material green;
    public int cost = 200;

    public GameObject towerPrefab;
    public Resources resourceScript;
    // Start is called before the first frame update
    void Start()
    {
        resourceScript = GetComponent<Resources>();
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
                if(hit.collider.gameObject.tag == "Field"){
                    OnStartup ifFieldOccupied = hit.collider.gameObject.GetComponent<OnStartup>();
                    Debug.Log(ifFieldOccupied);
                    if(ifFieldOccupied.isOccupied == false && resourceScript.checkResources(cost)){
                        Vector3 towerPos = new Vector3(hit.collider.gameObject.transform.position.x, 2, hit.collider.gameObject.transform.position.z);
                        GameObject tower = Instantiate(towerPrefab, towerPos, Quaternion.identity);
                        resourceScript.setResource(cost);
                        tower.tag = "Tower";
                        ifFieldOccupied.isOccupied = true;
                    }
                }
                Debug.Log("Hit: " + hit.collider.gameObject.tag);
            }
        }
    }
}
