using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	Vector3 offset;

	void Start () {
		// Calculate initial distance from player to camera.
		offset = transform.position - player.transform.position;
	}

	void LateUpdate () {
		// Maintains the camera to the distance set by initial offset calculation.
		transform.position = player.transform.position + offset;
	}

}
