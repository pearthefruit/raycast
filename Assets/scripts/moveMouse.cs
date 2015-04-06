using UnityEngine;
using System.Collections;

public class moveMouse : MonoBehaviour {

	public Transform player;
	private Vector3 destination;
	public float speed = 10f;
	private Vector3 direction;

	Rigidbody rbody;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray  = Camera.main.ScreenPointToRay (Input.mousePosition );
		RaycastHit cursorInfo = new RaycastHit();

		if (Physics.Raycast (ray, out cursorInfo, 3000f)) {
			Debug.Log ("cursor is currently hovering over location" + cursorInfo.collider.name);

			if (Input.GetMouseButtonDown (0)) {
				destination = (cursorInfo.point);


			}
		}
		Vector3 moveDirection = destination - transform.position;
		moveDirection /= moveDirection.magnitude;
		rbody.AddForce (moveDirection * speed);
	}
}
