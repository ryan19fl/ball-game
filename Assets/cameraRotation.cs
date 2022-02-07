using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousex= Input.GetAxis("Mouse X")*rotationSpeed;
        float mousey = Input.GetAxis("Mouse Y")*rotationSpeed;
        transform.rotation = Quaternion.Euler(0, mousex, 0) * transform.rotation;
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(-mousey, 0, 0) * camera.transform.localRotation;
    }
}
