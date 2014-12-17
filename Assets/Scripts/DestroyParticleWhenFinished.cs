using UnityEngine;
using System.Collections;

public class DestroyParticleWhenFinished : MonoBehaviour 
{
	void Update () 
	{
		if (!particleSystem.IsAlive ()) 
		{
			Destroy(gameObject);
		}
	}
}
