using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	private Animator animator;
	
	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		animator.SetBool ("JumpNow", false);
		if (Input.GetButtonDown ("Jump"))
		{
			animator.SetBool ("JumpNow",true);
			Debug.Log ("jump");
		}
	}
}
