using UnityEngine;

public class carecterMovement : MonoBehaviour
{
	public float speed = 1.0f;
	public string horizontalAxis = "Horizontal";
	public string verticalAxis = "Vertical";
	
	private Animator animator;
	private Vector3 originalScale;
	
	// Use this for initialization
	void Start ()
	{
		originalScale = transform.localScale;
		animator = GetComponentInChildren <Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 movementVector =  (Vector3.right * Input.GetAxis(horizontalAxis) + Vector3.up * Input.GetAxis(verticalAxis)) * speed * Time.deltaTime;
		transform.position += movementVector;
		
		animator.SetBool("walk",false);
		if(movementVector != Vector3.zero)
		{
			animator.SetBool("walk",true);
		}
		
		float dotProduct = Vector3.Dot(Vector3.right, movementVector);
		
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
