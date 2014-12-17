using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
	public float initialHP = 5.0f;
	private float currentHP;

	public float HealthPresentage
	{
		get{ return currentHP / initialHP; }
	}
	// Use this for initialization
	void Start () 
	{
		currentHP = initialHP;
	}

	public void ReduceHealth(float amount)
	{
		currentHP -= amount;
		if (currentHP <= 0.0f) 
		{
			Destroy(gameObject);
		}
	}

}
