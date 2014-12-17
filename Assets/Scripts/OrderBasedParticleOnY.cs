using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OrderBasedParticleOnY : MonoBehaviour 
{
	public float floatToInRatio = 1000.0f;

	private List<Renderer> renList = new List<Renderer>();

	// Use this for initialization
	void Start ()
	{
		ParticleSystem[] partArray = GetComponentsInChildren<ParticleSystem>();
		foreach(ParticleSystem part in partArray)
		{
			renList.Add (part.renderer);
			part.renderer.sortingLayerID = 0;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		foreach (Renderer ren in renList)
			{
				ren.sortingOrder = (int)(transform.position.y * -floatToInRatio);
			}
	
		}
}
