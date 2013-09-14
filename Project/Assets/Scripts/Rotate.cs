using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
	public float speed = 5;

    // ############################################################################################ // #UNITY FUNCTION
    void Start()
    {
        //Debug.Log("Teste commit");
    }
    // ############################################################################################ // #UNITY FUNCTION
	void Update () 
	{
		transform.Rotate( (Vector3.up * speed) * Time.deltaTime , Space.World );
	}
}
