using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public GameObject catPrefab;
	public GameObject mousePrefab;

	public static List<GameObject> listOfCats = new List<GameObject>();
	public static List<GameObject> listOfMouses = new List<GameObject>();

	// Use this for initialization
	void Start () {
		listOfCats.Clear ();
		listOfMouses.Clear ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit rayHit = new RaycastHit();

		if ( Physics.Raycast ( ray, out rayHit, 100f ) ) {
			if ( Input.GetMouseButtonDown (0) ) {
				GameObject newCat = (GameObject)Instantiate( catPrefab, rayHit.point + new Vector3(0f, 1f, 0f), Quaternion.identity );
				listOfCats.Add ( newCat );
			}
			if ( Input.GetMouseButtonDown (1) ) {
				GameObject newMouse = (GameObject)Instantiate( mousePrefab, rayHit.point + new Vector3(0f, 1f, 0f), Quaternion.identity );
				listOfMouses.Add ( newMouse );
			}
		}
	
	}
}
