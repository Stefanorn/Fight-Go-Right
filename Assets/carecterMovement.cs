using UnityEngine;
using System.Collections;

public class carecterMovement : MonoBehaviour {
	public float speed = 1.0f;
	public string horizontalAxis = "Horizontal";
	public string verticalAxis = "Vertical";

	private Animator animator;
	private SimpleCCD[] ikSolvers;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		ikSolvers = GetComponentsInChildren<SimpleCCD>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		Vector3 movementVector = (Vector3.right * Input.GetAxis(horizontalAxis) + Vector3.up * Input.GetAxis(verticalAxis)) * speed * Time.deltaTime;
		transform.position += movementVector;
		if (movementVector != Vector3.zero) 
		{
			animator.SetBool ("walk", true);
		} 
		else 
		{
			animator.SetBool ("walk",false);
		}
		float dotProduct = Vector3.Dot (Vector3.right, movementVector);
		if (dotProduct > 0) 
		{
			Vector3 newRotation = transform.eulerAngles;
			newRotation.y = 0.0f;
			transform.eulerAngles = newRotation;
			foreach(SimpleCCD solver in ikSolvers)
			{
				solver.reverseAngleLimits = false;
			}
		}
		else if(dotProduct < 0 )
		{
			Vector3 newRotation = transform.eulerAngles;
			newRotation.y = 180.0f;
			transform.eulerAngles = newRotation;
			foreach(SimpleCCD solver in ikSolvers)
			{
				solver.reverseAngleLimits = true;
			}
		}


	
	}
}
