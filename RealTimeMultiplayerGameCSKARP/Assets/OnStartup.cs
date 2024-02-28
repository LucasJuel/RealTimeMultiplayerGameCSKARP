using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OnStartup : MonoBehaviour
{   
    public GameObject obj;
    private bool isOccupied = false;
    MeshRenderer m_Render;
    Color OriginalColor;
    // Start is called before the first frame update
    void Start()
    {
        m_Render = obj.GetComponent<MeshRenderer>();
        OriginalColor = m_Render.material.color;
    }
    // Update is called once per frame
    void OnMouseOver(){
        if(isOccupied){
            m_Render.material.color = Color.red;
        } else {
            m_Render.material.color = Color.green;
        }
    }

    void OnMouseExit(){
        m_Render.material.color = OriginalColor;
    }
}
