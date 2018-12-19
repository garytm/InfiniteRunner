using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform platformGenerationPoint;
    private float platformDistance;
    private float platformWidth;
    public float platformDistanceMin;
    public float platformDistanceMax;
	void Start ()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	void Update ()
    {
		if(transform.position.x < platformGenerationPoint.position.x)
        {
            platformDistance = Random.Range(platformDistanceMin, platformDistanceMax);
            Instantiate(platform, transform.position, transform.rotation);
            transform.position = new Vector3(transform.position.x + platformWidth + platformDistance, transform.position.y, transform.position.z);
        }
	}
}
