using UnityEngine;
using System.Collections;

public class KeyboardManager : MonoBehaviour {
	
	public GameObject player;
	
	private Runner runner;
	
	// Use this for initialization
	void Start () {
	
		runner = player.GetComponent<Runner>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		 if(Input.GetKey(KeyCode.UpArrow)){
			
			//
			// call the jump method of the player game object
			// 
			
			Debug.Log("UP");
			
			runner.Jump();
	
		}
		
		if(Input.GetKey(KeyCode.DownArrow)){
			
			//
			// call the slide method of the player game object
			// 
			
			//player.transform.Translate(0, -1.0f * Time.deltaTime, 0);
	
			runner.Slide();
			
		}
		
		
			
	}
}
