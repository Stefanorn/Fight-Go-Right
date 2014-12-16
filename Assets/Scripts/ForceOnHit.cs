using UnityEngine;
using System.Collections;

public class ForceOnHit : MonoBehaviour 
{
	public float force = 10.0f;
	public ForceMode forceMode;

	void OnTriggerEnter()
	{
		rigidbody.AddForce (Vector3.right * force, forceMode);
	}

}
