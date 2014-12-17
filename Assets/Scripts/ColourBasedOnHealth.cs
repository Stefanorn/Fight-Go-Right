using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ColourBasedOnHealth : MonoBehaviour 
{
	public Color[] healthColors = { Color.green, Color.yellow, Color.red };
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
		float sigleColorPresentage = 1.0f/(float)(healthColors.Length-1);

		float HealthPresentage = healthCompoment.HealthPresentage;

		int colorIndex = 0;

		while (HealthPresentage > sigleColorPresentage) 
		{
			HealthPresentage -= sigleColorPresentage;
			colorIndex++;
		}

		Color lowColor = healthColors [colorIndex];
		Color highColor = healthColors [colorIndex+1];

		imageCompoment.color = Color.Lerp (lowColor, highColor, (HealthPresentage-1));
	}
}
