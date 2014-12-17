using UnityEngine;
using System.Collections;

public class FlyOnTrigger : MonoBehaviour {

	private Animator animator;

	void Start ()
	{
		animator = GetComponentInParent<Animator> ();
	}

	void OnTriggerEnter () 
	{
		animator.SetBool ("Fly", true);
	}
	void OnTriggerExit ()
	{
		animator.SetBool ("Fly", false);
	}
}
