using UnityEngine;
using System.Collections;

public class SpawnOnHit : MonoBehaviour 
{
	public GameObject objectToSpawn;

	public bool parenToTransform = false;

	void OnTriggerEnter()
	{
		GameObject instance = Instantiate (objectToSpawn, transform.position, Quaternion.identity) as GameObject;

		if (parenToTransform)
		{
			instance.transform.parent = transform;
		}
	}
}
