using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFillBasedOnHealth : MonoBehaviour 
{
	private Health healthCompoment;
	private Image imageCompoment;
	// Use this for initialization
	void Start ()
	{
		healthCompoment = GetComponentInParent<Health> ();
		imageCompoment = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		imageCompoment.fillAmount = healthCompoment.HealthPresentage;
	}
}
