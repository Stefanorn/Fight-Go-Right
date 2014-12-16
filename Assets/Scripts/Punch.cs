using UnityEngine;
using System.Collections;

public class Punch : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		animator.SetBool ("PunchNow", false);
		if (Input.GetButtonDown ("Fire1"))
		{
			animator.SetBool ("PunchNow",true);
		}
	}
}
