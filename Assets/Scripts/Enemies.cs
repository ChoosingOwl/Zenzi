using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

	
	protected Transform playerTransform;
	protected Transform myTransform;


	protected int Health;
	protected int MoveSpeed;
	protected int Attack;

	protected float MovementSpeed;
	protected float RotationSpeed;
	protected float DetectionRange;
	
	protected void Awake() {
		myTransform = transform;
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}




	void Update () {

	}

	protected virtual void movement () {


	
		if (Vector3.Distance(playerTransform.position, myTransform.position) < DetectionRange)
		{
			//Rotate to player
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(playerTransform.position - myTransform.position), RotationSpeed * Time.deltaTime);
			
			//Move to player
			myTransform.position += myTransform.forward * MovementSpeed * Time.deltaTime;
		
		}
	}

}

