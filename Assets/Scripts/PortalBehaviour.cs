using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBehaviour : MonoBehaviour
{
    public GameObject entryPortal;
    public GameObject exitPortal;
    private PlayerBehaviour player;

	void Start ()
    {
        player = FindObjectOfType<PlayerBehaviour>();
	}
	
	void Update ()
    {
        Teleport();
	}
    void Teleport()
    {
        if (player.teleporting)
        {
            player.transform.position = exitPortal.transform.position;
        }
    }
}
