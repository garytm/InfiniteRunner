using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    //public ObjectPool objectPool;
    public GameObject platform;
    public GameObject[] platforms;
    public Transform platformGenerationPoint;
    public float platformDistanceMin;
    public float platformDistanceMax;

    private int platformSelector;
    private float platformDistance;
    private float platformWidth;
    private float[] platformWidths;
    void Start ()
    {
        //platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
        platformWidths = new float[platforms.Length];

        for (int i = 0; i < platforms.Length; i++)
        {
            platformWidths[i] = platforms[i].GetComponent<BoxCollider2D>().size.x;
        }
	}
	
	void Update ()
    {
		if(transform.position.x < platformGenerationPoint.position.x)
        {
            platformDistance = Random.Range(platformDistanceMin, platformDistanceMax);
            //GameObject newPlatform = objectPool.GetPooledObject();
            //newPlatform.transform.position = transform.position;
            //newPlatform.transform.rotation = transform.rotation;
            //newPlatform.SetActive(true);
            platformSelector = Random.Range(0, platforms.Length); 
            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + platformDistance, transform.position.y, transform.position.z);
            Instantiate(platforms[platformSelector], transform.position, transform.rotation);
        }
	}
}
