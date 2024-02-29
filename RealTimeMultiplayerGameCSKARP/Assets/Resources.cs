using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    // Start is called before the first frame update
    public float money = 10000f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setResource(float moneySpent){
        if(checkResources(moneySpent)){
            money = money - moneySpent;
        }
    }

    public bool checkResources(float moneySpent){
        if(money >= moneySpent){
            return true;
        }else {
            return false;
        }
    }
}
