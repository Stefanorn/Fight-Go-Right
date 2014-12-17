using UnityEngine;
using System.Collections;

public class AIPunch : MonoBehaviour {

	private Animator animator;
	private AIMovement aiMovement;

	public float attackDelay = 0.5f;

	private bool isAttacking = false;
	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator> ();
		aiMovement = GetComponentInParent<AIMovement> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		animator.SetBool ("PunchNow", false);
		if (aiMovement.closestDistance < aiMovement.nearGoalThreshold && !isAttacking)
		{
			isAttacking = true;
			Invoke("Attack", attackDelay);
		}
	}
	void Attack()
	{
		animator.SetBool ("PunchNow",true);
		isAttacking = false;
	}
}
