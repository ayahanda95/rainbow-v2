using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonGravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -1.62F, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
