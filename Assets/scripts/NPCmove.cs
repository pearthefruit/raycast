using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCmove : MonoBehaviour {
	public float speed = 100f;
	private Vector3 destination;
	public List<NPCmove> NPCs = new List<NPCmove>();
	public NPCmove NPCprefab;
	public float NPCspeed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//go forward
		GetComponent<Rigidbody>().AddForce (transform.forward * speed, ForceMode.Acceleration );

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();

		if (Physics.Raycast (ray, out hit, 1000f)){

			if(Input.GetMouseButtonDown(0) && hit.collider.tag != "Player"){
				Vector3 spawn = hit.point + hit.normal;
				NPCmove newNPC = Instantiate(NPCprefab, spawn, Quaternion.Euler(0f, 0f, 0f)) as NPCmove;
				NPCs.Add (newNPC);
			}
		}






//
//				NPCmove NPC = Instantiate (npcPrefab, hit.point + hit.normal, Quaternion.identity) 
//
//		
//
//
//
//		if ( Physics.Raycast (ray, 5f) ) {
//			transform.Rotate (0f, Random.Range (-90f, 90f ), 0f) ;
//		}
	}
}
