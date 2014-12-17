using UnityEngine;

public class AIMovement : MonoBehaviour
{
	public float speed = 1.0f;
	public float nearGoalThreshold = 0.1f;

	[HideInInspector]
	public float closestDistance;
	
	private Animator animator;
	private Vector3 originalScale;
	private Transform playerTransform;
	
	// Use this for initialization
	void Start ()
	{
		originalScale = transform.localScale;
		animator = GetComponentInChildren <Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(playerTransform == null)
		{
			playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		}
		closestDistance = Mathf.Infinity;
		GameObject closestEnemyPosition = null;
		foreach(GameObject obj in GameObject.FindGameObjectsWithTag("EnemyTargetPosition"))
		{
			float sqrDistance = (obj.transform.position - transform.position).sqrMagnitude;
			if( sqrDistance < closestDistance)
			{
				closestDistance = sqrDistance;
				closestEnemyPosition = obj;
			}
		}
		if (closestEnemyPosition == null || closestDistance < nearGoalThreshold) 
		{
			animator.SetBool("walk",false);
			return;
		}

		Vector3 movementVector =  (closestEnemyPosition.transform.position - transform.position).normalized * speed * Time.deltaTime;
		
		animator.SetBool("walk",false);
		if(closestDistance > nearGoalThreshold)
		{
			transform.position += movementVector;

			animator.SetBool("walk",true);

			//Face player
			float dotProduct = Vector3.Dot(Vector3.right, playerTransform.position - transform.position);
			
			if(dotProduct > 0)
			{
				transform.localScale = originalScale;
			}
			else if(dotProduct < 0)
			{
				Vector3 newScale = originalScale;
				newScale.x = -originalScale.x;
				transform.localScale = newScale;
			}
		}
		
		//Attempt to reverse animation (Maintain facing)
		/*
		if(Vector3.Dot(Vector3.right, movementVector) >= 0)
		{
			animator.speed = 1.0f;
		}
		else
		{
			animator.speed = -1.0f;
		}
		*/
	}
}
