using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Raycast : MonoBehaviour
{
    public Tilemap tilemap;
    public Vector3Int cellPosition;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cellPosition = tilemap.WorldToCell(mouseWorldPos);
            TileBase clickedTile = tilemap.GetTile(cellPosition);
            Debug.Log(clickedTile);

            if (clickedTile != null)
            {
                // Do something with the clicked tile
                Debug.Log("Clicked on tile: " + clickedTile.name);
            }
        }
    }
    }
}
