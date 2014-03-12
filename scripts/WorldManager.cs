using UnityEngine;
using System.Collections;

public class WorldManager : MonoBehaviour {
	
	public Transform floorPrefab; 
	
	private int numObjects = 5;
	
	private Vector3 nextPosition;
	
	private Vector3 minSize, maxSize;
	
	// Use this for initialization
	void Start () {
	
		nextPosition = transform.localPosition;
		
		GenerateFloor();
		
	}
	
	// Update is called once per frame
	void Update () {
		
			Debug.Log("manager");
	
	}
	
	private void GenerateFloor(){
		
		/*for(int i=0; i < numObjects; i++){
			
			Transform floorInstance = (Transform) Instantiate( floorPrefab );
			
			floorInstance.localPosition = nextPosition;
			
			nextPosition.x += floorInstance.localPosition.x;
		}*/
		
	}
		
}
