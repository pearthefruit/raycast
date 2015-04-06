using UnityEngine;
using System.Collections;

public class ObstaclePlacer : MonoBehaviour {

	public Transform obstaclePrefab; //assign in inspector
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//generate a ray before shooting a raycast
		Ray cursorRay = Camera.main.ScreenPointToRay ( Input.mousePosition );
		
		//reserve in memory a "blank" object to hold impact data
		RaycastHit cursorRayInfo = new RaycastHit();
		
		if ( Physics.Raycast ( cursorRay, out cursorRayInfo, 1000f )) {
			Debug.Log ( cursorRayInfo.collider.name );

			if (Input.GetMouseButtonDown (0) ) {  //0 will be left click, 1 right click, 2 middle click
				Instantiate (obstaclePrefab, cursorRayInfo.point, Random.rotation );
			}
		}
	}
}
