using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public GameObject bulletprefab;
    GameObject bulletTempRef;
    private Rigidbody rb;
    public float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletTempRef = Instantiate(bulletprefab);
            rb = bulletTempRef.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * bulletspeed;
        }
    }
}
