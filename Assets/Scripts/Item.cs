using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollionEnter(Collision2D other)
	{

	

	}


	void OnTriggerEnter2D (Collider2D other)
	{
		//print (other.name);
		if (other.gameObject.CompareTag ("Arrow")) {
			Destroy (this);

		}
	}



}
