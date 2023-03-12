using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetGravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -9.81F, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
