using UnityEngine;
using System.Collections;

public class HitReaction : MonoBehaviour 
{
	private Animator animator;
	// Use this for initialization
	void Start () 
	{
		animator = GetComponentInChildren<Animator> ();
	}
	void OnTriggerEnter ()
	{
		animator.SetBool ("Hit", true);
		StartCoroutine (Reset ());
	}

	IEnumerator Reset()
	{
		yield return null;
		animator.SetBool ("Hit", false);
	}
}
