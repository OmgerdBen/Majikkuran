using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour {

	public bool AimingMode = false;
	public GameObject	AimLight;



	// Use this for initialization
	void Start () {



	
	}
	
	// Update is called once per frame
	void Update () {
		if (!AimingMode)
			return;

		AimLight.transform.position = Input.mousePosition;
		AimLight.GetComponent<Light> ().transform.position = Input.mousePosition;


	
	}

	void OnMouseEnter()
	{
		AimingMode = true;
		AimLight = Instantiate (AimLight) as GameObject;
		AimLight.SetActive (true);
	}


	void OnMouseExit()
	{
		AimingMode = false;

	}



}
