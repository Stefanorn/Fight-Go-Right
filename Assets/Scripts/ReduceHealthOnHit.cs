using UnityEngine;
using System.Collections;

public class ReduceHealthOnHit : MonoBehaviour 
{
	public float damageAmount = 1.0f;

	void OnTriggerEnter(Collider col)
	{
		Health healthCompoment = col.GetComponentInParent<Health> ();
		if (healthCompoment)
		{
			healthCompoment.ReduceHealth(damageAmount);
		}
	}
}
