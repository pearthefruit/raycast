using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 10)){
			if (hit.collider.gameObject.tag == "npc"){
				Destroy (this.gameObject);
			}
		}
	}
}
