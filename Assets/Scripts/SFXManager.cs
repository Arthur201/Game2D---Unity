using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

	public static SFXManager instance;

	public GameObject CoinParticles; 

	void Awake(){
		if(instance == null){
			instance = this;
		}
	}


	public void ShowCoinParticles(GameObject obj){
		Instantiate(CoinParticles, obj.transform.position, Quaternion.identity);
	}
 
}
