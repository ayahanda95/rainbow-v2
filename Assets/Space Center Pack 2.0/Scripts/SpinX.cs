using UnityEngine;
using System.Collections;

public class SpinX: MonoBehaviour

    //This script is attached to any object you want to spin on the x axis.
{
	public float speed = 10f;


	void Update ()
	{
        transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * speed, Space.Self);
    }
}