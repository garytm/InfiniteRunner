using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public PlayerBehaviour player;
    private Vector3 prevPlayerPosition;
    private Vector3 moveDistance;
	void Start ()
    {
        player = FindObjectOfType<PlayerBehaviour>();
        //setting the previoius player position to equal it's current position in the start method
        //to give us something to use before it is updated
        prevPlayerPosition = player.transform.position;
    }
	
	void Update ()
    {
        //the difference between the players current x pos and it's previous x pos is how much the camera should move
        moveDistance.x = player.transform.position.x - prevPlayerPosition.x;
        moveDistance.y = player.transform.position.y - prevPlayerPosition.y;

        //update the cameras x position using the moveDistance variable
        transform.position = new Vector3(transform.position.x + moveDistance.x, transform.position.y + moveDistance.y, transform.position.z);
        prevPlayerPosition = player.transform.position;
	}
}
