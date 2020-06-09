using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector3 : MonoBehaviour
{
    Vector3 vector = new Vector3(1.0f, 2.0f, 0);
    // Start is called before the first frame update
    void Start()
    {
        vector += new Vector3(1.0f, 0, 0);

        this.transform.position = vector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
