using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(Vector3.right * 30.0f, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
