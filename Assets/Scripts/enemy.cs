using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public float speed;
	private Vector3 move;
	private int trunAngle = 180;
	// Use this for initialization
	void Start () {
		move = new Vector3(-speed, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		// move the arrow
		this.transform.position += move * Time.deltaTime;
	}

	void OnCollisionEnter2D ( Collision2D impact ) {
		string tag = impact.gameObject.tag;
		if(tag == "wall") {
			turnAround();
		}
	}

	void OnCollisionStay2D ( Collision2D impact ) {
		string tag = impact.gameObject.tag;
		if(tag == "wall") {
			turnAround();
		}
	}

	void turnAround() {
		move = -move;
		transform.rotation = Quaternion.Euler(0, trunAngle, 0);
		if (trunAngle > 0) {
			trunAngle = 0;
		} else {
			trunAngle = 180;
		}
	}

}
