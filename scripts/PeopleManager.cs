using UnityEngine;
using System.Collections;

public class PeopleManager : MonoBehaviour {
	
	public Transform personPrefab;
	
	private float initialXPos = 2.5f;
	
	// Use this for initialization
	void Start () {
	
		generatePerson();
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
	}
	
	private void generatePerson(){
		
		Debug.Log ("people manager");
		
		Transform personInstance = (Transform) Instantiate( personPrefab );
		
		//
		// generate the prefab outside the camera
		//
		
		
		Vector3 cameraPosition = Camera.mainCamera.gameObject.transform.position;
		
		personInstance.localPosition = new Vector3( cameraPosition.x + 2.0f, 0.0f, 0.0f);
		
		
		
	}
}
