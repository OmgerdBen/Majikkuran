using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public float delay = 3f;

	void Awake()
	{
		Destroy (gameObject, delay);
	}

}
