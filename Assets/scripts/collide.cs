using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {
	public GameObject player;
	public float speed = 10f;
	public float Radius = 30f;
	GameObject PC;
	Rigidbody rbody;
	Vector3 initialPos;
	// Use this for initialization
	void Start () {
		PC = GameObject.Find("Player");
		rbody = GetComponent<Rigidbody>();
		initialPos = player.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		rbody.velocity = transform.forward * speed;
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit = new RaycastHit();
		if (Physics.Raycast(ray, out hit, 10f) && hit.collider.tag != "Player"){
			transform.Rotate (0, 0, 90);
			if (hit.collider.gameObject.tag == "Player"){
				Destroy (PC);
			}

		}
		Vector3 NPCtoPC = player.transform.position - transform.position;
		NPCtoPC /= NPCtoPC.magnitude;
		Ray NPCray = new Ray(transform.position, NPCtoPC);
		RaycastHit NPhit = new RaycastHit();

		bool Insight = (Physics.Raycast(NPCray, out NPhit, 33f) && NPhit.collider.tag == "Player");

		if (Insight){
			rbody.velocity = NPCtoPC * speed * 2f;
			if (Physics.Raycast(NPCray, out NPhit, 3f) && NPhit.collider.tag != "Player"){
				transform.Rotate (0f , 90f, 0f);

			}
			if (Vector3.Distance(transform.position, player.transform.position) < 6f) {
				player.transform.position = initialPos;
			}
		}
	}
}
