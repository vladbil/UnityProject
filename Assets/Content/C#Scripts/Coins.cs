﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
		}
	}
}