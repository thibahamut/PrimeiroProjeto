using UnityEngine;
using System.Collections;

public class RotateCapsule : MonoBehaviour {

    public float speed = 5;

    // ############################################################################################ // #UNITY FUNCTION
	void Start ()
    {
	    
	}
    // ############################################################################################ // #UNITY FUNCTION
	void Update ()
    {
        transform.Rotate((Vector3.right * speed) * Time.deltaTime, Space.World);
	}
    // ############################################################################################ // 
}
