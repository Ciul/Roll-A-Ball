using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	public int pickUpCount;
	private Rigidbody rb;
	private int count;
	
	void Start ()
	{
		pickUpCount 	= GameObject.FindGameObjectsWithTag ("Pick Up").Length;
		rb 				= GetComponent<Rigidbody> ();
		count 			= 0;
		winText.text 	= "";
		SetCountText ();
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Pick Up") {
			other.gameObject.SetActive (false);
			// Destroy (other.gameObject);

			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText () {
		countText.text = "Points: " + count.ToString ();
		if (count >= pickUpCount) {
			winText.text = "You Win!";
		}
	}

}
