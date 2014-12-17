using UnityEngine;
using System.Collections;

public class LimitYMovement : MonoBehaviour 
{
	public float minY = 0.0f;
	public float maxY = 10.0f;


	void LateUpdate () 
	{
		Vector3 newPosition = transform.position;
		newPosition.y = Mathf.Clamp (newPosition.y, minY, maxY);
		transform.position = newPosition;
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;

		Vector3 origin = new Vector3 (-20.0f, minY, 0.0f);
		Vector3 origin2 = new Vector3 (-20.0f, maxY, 0.0f);
		Gizmos.DrawRay (origin, Vector3.right*100);
		Gizmos.DrawRay (origin2, Vector3.right*100);

	}
}
