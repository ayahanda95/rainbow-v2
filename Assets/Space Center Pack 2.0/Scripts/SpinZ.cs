using UnityEngine;
using System.Collections;

public class SpinZ: MonoBehaviour

    //This script is attached to any object you want to spin on the Z axis.
{
	public float speed = 10f;


	void Update ()
	{
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speed, Space.Self);
    }
}