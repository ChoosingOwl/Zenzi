using UnityEngine;
using System.Collections;

public class LargeEnemy : Enemies {


		// Use this for initialization
		void Start () {
			
			MovementSpeed = 2.5f;
			RotationSpeed = 1.0f;
			DetectionRange = 10;
			
			base.Awake();
			
			
			
		}
		
		// Update is called once per frame
		void Update () {
			
			base.movement();
		}
	}
