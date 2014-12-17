using UnityEngine;
using System.Collections;

public class OrderBasedOnY : MonoBehaviour 
{
	public float floatToInRatio = 1000.0f;

	private Renderer[] renArray;

	// Use this for initialization
	void Start ()
	{
		renArray = GetComponentsInChildren<Renderer> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		foreach (Renderer ren in renArray)
			{
				ren.sortingOrder = (int)(transform.position.y * -floatToInRatio);
			}
	
		}
}
