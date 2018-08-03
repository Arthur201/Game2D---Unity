using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour {

	// Use this for initialization

public float delay = 3f;

	void Start () {

		Destroy(gameObject, delay);
		
	}

}
