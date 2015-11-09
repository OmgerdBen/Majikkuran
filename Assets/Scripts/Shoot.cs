using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {


	public float speed = 10f;
	public Rigidbody2D BlueArrow;
	public Rigidbody2D RedArrow;


	
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		//In Unity Fire1 is left ctrl or left click
		if (Input.GetButtonDown ("Fire1")) 
		{
			Vector2 SpawnPos = transform.position;
			//See below for source of the following 4 lines
			//get postion of cursor
			Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
			//direction from spawn to target
			Vector2 direction = target - SpawnPos;
			//
			direction.Normalize();
			//create a Quaternion with dimensions to make the arrow go the right direction
			Quaternion Qrotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
			//instantiate the arrow
			Rigidbody2D ArrowClone = Instantiate(RedArrow,
			                                   transform.position,
			                                   Qrotation)as Rigidbody2D;
			//make the arrow go in the direction with speed
			ArrowClone.velocity = transform.TransformDirection(direction * speed);
		}

		if (Input.GetButtonDown ("Fire2")) 
		{
			Vector2 SpawnPos = transform.position;
			//See below for source of the following 4 lines
			//get postion of cursor
			Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
			//direction from spawn to target
			Vector2 direction = target - SpawnPos;
			//
			direction.Normalize();
			//create a Quaternion with dimensions to make the arrow go the right direction
			Quaternion Qrotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
			//instantiate the arrow
			Rigidbody2D ArrowCloneB = Instantiate(BlueArrow,
			                                     transform.position,
			                                     Qrotation)as Rigidbody2D;
			//make the arrow go in the direction with speed
			ArrowCloneB.velocity = transform.TransformDirection(direction * speed);
		}

	
	}






	//http://answers.unity3d.com/questions/736511/shoot-towards-mouse-in-unity2d.html
	//script from user SgtPancakes
}
