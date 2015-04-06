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

		Ray ray = Ray( Camera.main.ScreenPointToRay(Input.mousePosition);
		              RaycastHit hit = new RaycastHit();

		              if (Physics.Raycast (ray, out hit, 1000f)){
			if (Input.GetMouseButtonDown(0)) && hit.collider.tag == "player"){
				NPCmove NPC = Instantiate (npcPrefab, hit.point + hit.normal, Quaternion.identity) 
			}
		}



//		if ( Physics.Raycast (ray, 5f) ) {
//			transform.Rotate (0f, Random.Range (-90f, 90f ), 0f) ;
//		}
	}
}
