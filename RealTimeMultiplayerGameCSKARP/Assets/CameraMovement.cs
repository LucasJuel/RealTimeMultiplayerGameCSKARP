using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    public float edgeBoundary = 10.0f; // Distance from edge to start moving camera
    public float zoomSpeed = 5.0f; // Speed of zooming in/out
    public float minZoom = 5.0f; // Minimum zoom level
    public float maxZoom = 20.0f; // Maximum zoom level

    // Update is called once per frame
    void Update()
    {
        MoveCameraBasedOnCursor();
        ZoomCameraBasedOnScroll();
    }

    private void MoveCameraBasedOnCursor()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.mousePosition.x >= Screen.width - edgeBoundary)
        {
            // Move camera right
            moveDirection.x += 1;
        }
        if (Input.mousePosition.x <= edgeBoundary)
        {
            // Move camera left
            moveDirection.x -= 1;
        }
        if (Input.mousePosition.y >= Screen.height - edgeBoundary)
        {
            // Move camera up
            moveDirection.y += 1;
        }
        if (Input.mousePosition.y <= edgeBoundary)
        {
            // Move camera down
            moveDirection.y -= 1;
        }

        transform.position += moveDirection.normalized * movementSpeed * Time.deltaTime;
    }

    private void ZoomCameraBasedOnScroll()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Camera camera = GetComponent<Camera>();

        if (camera.orthographic)
        {
            // Adjust orthographic size for zooming
            camera.orthographicSize -= scroll * zoomSpeed;
            camera.orthographicSize = Mathf.Clamp(camera.orthographicSize, minZoom, maxZoom);
        }
        else
        {
            // Adjust field of view for zooming (if you're using a perspective camera)
            camera.fieldOfView -= scroll * zoomSpeed;
            camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, minZoom, maxZoom);
        }
    }
}