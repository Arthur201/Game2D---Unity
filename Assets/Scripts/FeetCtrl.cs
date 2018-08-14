using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetCtrl : MonoBehaviour {


	GameObject player;
	
	void Start () {

		player = transform.parent.gameObject;
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("MovingPlatform")){
			Debug.Log("entrou");
			player.transform.parent = other.transform;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if(other.gameObject.CompareTag("MovingPlatform")){
			Debug.Log("saiu");
			player.transform.parent = null;
		}
	}
	
}
