using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public PlayerController thePlayer;      // location of player

    private Vector3 lastPlayerPosition;     // x, y, z position of player
    private float distanceToMove;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        // distance we want camera to move (x value current position - x value last position)
        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

        // do not change y and z value (so if the player jumps, the camera will not move up and down)
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

        lastPlayerPosition = thePlayer.transform.position;
	}
}
