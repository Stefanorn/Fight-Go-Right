using UnityEngine;
using System.Collections;

public class RandomizePitchOnAwake : MonoBehaviour 
{
	public float minPitch = 0.8f;
	public float maxPitch = 1.2f;
	// Use this for initialization
	void Start () 
	{
		audio.pitch = Random.Range (minPitch, maxPitch);
	}
}
