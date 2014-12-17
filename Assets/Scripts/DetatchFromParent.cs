using UnityEngine;
using System.Collections;

public class DetatchFromParent : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		transform.parent = null;
	}
}
