using UnityEngine;
using System.Collections;

public class ForceOnHit : MonoBehaviour 
{
	public float force = 10.0f;
	public ForceMode forceMode;

	[Header("Optinoal refrences")]
	public Transform forceOrigion;

	void Start()
	{
		if (forceOrigion == null) 
		{
			forceOrigion = transform;
		}
	}

	void OnTriggerEnter(Collider Col)
	{
		if(Col.rigidbody != null)
		{
			Vector3 forceDerection = (Col.transform.position - forceOrigion.position).normalized;
			Col.rigidbody.AddForce (forceDerection * force, forceMode);
		}
	}

}
