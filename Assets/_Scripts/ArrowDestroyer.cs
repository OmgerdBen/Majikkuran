using UnityEngine;
using System.Collections;

public class ArrowDestroyer : MonoBehaviour {



	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Arrow")) {
			Destroy (other.gameObject);
			print ("collision");
		}
		if (other.CompareTag ("Arrow")) {
			print ("Collide");
		}

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Arrow")) {
			Destroy (other.gameObject);
			print ("collision3");
		}

	}
/**
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Arrow")) {
			Destroy (other.gameObject);
			print ("collision");
		}

	}
	**/
}
