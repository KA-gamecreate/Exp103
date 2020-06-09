using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector3no2 : MonoBehaviour
{
    Vector3 vector = new Vector3(1, 2, 0);

    // Start is called before the first frame update
    void Start()
    {
        vector *= 2.0f;
            Debug.Log(vector);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
