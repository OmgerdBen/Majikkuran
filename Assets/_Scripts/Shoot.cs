using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {


	public Rigidbody Arrow;
	public float speed = 10f;
	public Rigidbody2D BlueArrow;


	
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

	
		if (Input.GetButtonDown ("Fire1")) 
		{
			Vector3 launchPos = transform.position;
			
			//get current mouse position in 2d screen coordinates
			Vector3 mousePos2D = Input.mousePosition;
			//Convert the mouse position to 3d world coords
			mousePos2D.z = -Camera.main.transform.position.z;
			Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
			//find the delta from the launch Pos to the mouse Pos3D
			Vector3 mouseDelta = mousePos3D-launchPos;

			Vector3 exp = mouseDelta;
			exp = exp * 2;
			Rigidbody ArrowClone = Instantiate(Arrow,
			                                   transform.position,
			                                   Quaternion.LookRotation(exp))
				as Rigidbody;

			ArrowClone.velocity = transform.TransformDirection(mouseDelta);
		}


		if (Input.GetButtonDown ("Fire2")) 
		{
			Vector3 launchPos = transform.position;
			
			//get current mouse position in 2d screen coordinates
			Vector3 mousePos2D = Input.mousePosition;
			//Convert the mouse position to 3d world coords
			mousePos2D.z = -Camera.main.transform.position.z;
			Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
			//find the delta from the launch Pos to the mouse Pos3D
			Vector3 mouseDelta = mousePos3D-launchPos;
			
			Vector3 exp = mouseDelta;

			Rigidbody2D ArrowCloneB = Instantiate(BlueArrow,
			                                   transform.position,
			                                   Quaternion.LookRotation(exp))
				as Rigidbody2D;
			
			ArrowCloneB.velocity = transform.TransformDirection(mouseDelta);
		}
			
	
	}







}
