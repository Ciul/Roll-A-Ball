using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveHorizontal;
	public float moveVertical;
	Vector3 position;

	void Start () {
		position = transform.position;
	}
	
	void Update () {
		moveHorizontal 		= Input.GetAxis ("Horizontal");
		moveVertical 		= Input.GetAxis ("Vertical");
		Vector3 movement 	= new Vector3 (moveHorizontal, 0.0f, moveVertical);

		position = position + movement;
		gameObject.transform.position = position;
	}

}
