using UnityEngine;
using System.Collections;

public class SpawnOnHit : MonoBehaviour 
{
	public GameObject objectToSpawn;
	void OnTriggerEnter()
	{
		Instantiate (objectToSpawn, transform.position, Quaternion.identity);
	}
}
