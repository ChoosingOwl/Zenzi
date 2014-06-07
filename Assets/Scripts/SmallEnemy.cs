using UnityEngine;
using System.Collections;

public class SmallEnemy : Enemies {




	// Use this for initialization
	 void Start () {
	
		MovementSpeed = 4.5f;
		RotationSpeed = 3.0f;
		DetectionRange = 10;

		 Transform playerTransform;
		 Transform myTransform;

		base.Awake();

	

	}
	
	// Update is called once per frame
	void Update () {
	
		base.movement();
	}
}
