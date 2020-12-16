using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.Runtime.InteropServices;

public class Shoot : MonoBehaviour
{
    public GameObject cube;
    public GameObject bullet;
    Rigidbody C;
    public Transform CameraPos;
    // Start is called before the first frame update
    void Start()
    {
        /*
        cube.transform.position = CameraPos.position + Vector3.forward * 0.5f;
        C = cube.GetComponent <Rigidbody>();
        C.useGravity = false;
        cube.SetActive(false);

        //cube.GetComponent<Rigidbody>() = C;
        */
    }    
    // Update is called once per frame
    void Update()
    {
        //bullet = Instantiate(cube);
    }

    public void CreateCube()
    {
        bullet = Instantiate(cube);
        bullet.transform.position = CameraPos.position + Vector3.forward * 0.5f;
        C = bullet.GetComponent<Rigidbody>();
        cube.SetActive(true);
        C.useGravity = true;
        C.AddForce(transform.forward * 500);
    }

}
