using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	public float speed = 5f;
	public float turnSpeed = 6f;
	Rigidbody rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rbody.AddForce (transform.forward * speed * Input.GetAxis("Vertical"));
		// rbody.AddForce (transform.right * speed * Input.GetAxis("Horizontal"));
		transform.Rotate ( 0f, Input.GetAxis ("Horizontal") * turnSpeed, 0f );
	}
}
