using UnityEngine;
using System.Collections;

public class OrderParticleBasedOnParent : MonoBehaviour 
{
	void Start () 
	{
		Renderer parentRen = transform.parent.GetComponentInParent<Renderer> ();
		particleSystem.renderer.sortingOrder = parentRen.sortingOrder;
	}
}
