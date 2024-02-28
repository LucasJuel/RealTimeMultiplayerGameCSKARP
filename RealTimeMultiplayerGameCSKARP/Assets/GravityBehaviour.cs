using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBehaviour : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = player.transform.position.y;
        player.transform.position = new Vector3(0, y - 0.1f, 0);
    }
}
