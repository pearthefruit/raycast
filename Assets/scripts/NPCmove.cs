using UnityEngine;
using System.Collections;

public class NPCmove : MonoBehaviour {
	public float speed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//go forward
		GetComponent<Rigidbody>().AddForce (transform.forward * speed, ForceMode.Acceleration );

		Ray ray = new Ray( transform.position, transform.forward );
		if ( Physics.Raycast (ray, 5f) ) {
			transform.Rotate (0f, Random.Range (-90f, 90f ), 0f) ;
		}
	}
}
