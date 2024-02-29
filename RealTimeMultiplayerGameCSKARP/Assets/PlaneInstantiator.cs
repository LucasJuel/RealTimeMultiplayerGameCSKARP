using UnityEngine;

public class PlaneInstantiator : MonoBehaviour
{
    public GameObject planePrefab;
    public int numberOfXPlanes = 10;
    public int numberOfZPlanes = 10;
    public float distanceBetweenPlanes = 10.0f;

    public Material green;
    public Material red;
    void Start()
    {
        InstantiatePlanes();
    }

    void InstantiatePlanes()
    {
        for (int i = 0; i < numberOfXPlanes; i++)
        {
            for(int j = 0; j < numberOfZPlanes ; j++){
                float xPos = i * distanceBetweenPlanes;
                float zPos = j * distanceBetweenPlanes;
                Vector3 planePosition = new Vector3(xPos, 0f, zPos);
                GameObject plane = Instantiate(planePrefab, planePosition, Quaternion.identity);
                plane.tag = "Field";
                plane.transform.localScale = planePrefab.transform.localScale * 12f;
                plane.transform.rotation = Quaternion.Euler(-90, 0, 0);
                plane.AddComponent<OnStartup>();
                plane.GetComponent<OnStartup>().obj = plane;
                plane.AddComponent<BoxCollider>();
                // if(i % 2 == 0){
                //     if(j % 2 == 0){
                //         plane.GetComponent<Renderer>().material = green;
                //     } else {
                //         plane.GetComponent<Renderer>().material = red;
                //     }
                // } else {
                //     if(j % 2 == 0){
                //         plane.GetComponent<Renderer>().material = red;
                //     } else {
                //         plane.GetComponent<Renderer>().material = green;
                
                //     }
                // }                
                // You can add any additional customization to the instantiated planes here.
            }
            
        }
    }
}
