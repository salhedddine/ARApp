using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeManager : MonoBehaviour
{
    GameObject A1;
    float T;

    // Start is called before the first frame update
    void Start()
    {
        T = Time.time;

        print(gameObject.name);

        A1 = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        float T2;
        T2 = Time.time - T;
        if (T2 > 3)
        {
            Destroy(gameObject);
            T = Time.time;

        }
    }
}
