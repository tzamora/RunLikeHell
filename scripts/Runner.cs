using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour {
	
	private float distanceFromObject; 
	
	private tk2dAnimatedSprite playerAnim;
	
	// Use this for initialization
	void Start () {
	
		playerAnim = GetComponent<tk2dAnimatedSprite>();
		
		Debug.Log("---->" + playerAnim);
		
	}
	
	// Update is called once per frame
	void Update () {
	
		 transform.Translate(1.0f * Time.deltaTime, 0, 0);
		
	}
	
	public float DistanceFromObstacle(Transform obstacle){
		
		distanceFromObject =  Mathf.Abs( transform.position.x - obstacle.position.x );
		
		return distanceFromObject;
		
	}
	
	public void Jump(){
		
		playerAnim.Play("PlayerFallingAnimation");
		
	}
	
	public void Slide(){
		
		playerAnim.Play("running");
		
	}
	
	public void Grab(){
		
		// grab another personv ( play player grab animation and the falling person animation )
		
	}
}
