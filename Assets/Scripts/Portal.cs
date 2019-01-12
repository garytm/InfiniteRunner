using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public int code;
    float timer = 0.0f;

    void Update()
    {
        if (timer > 0)
        {
            timer = -Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && timer <=0)
        {
            foreach (Portal p in FindObjectsOfType<Portal>())
            {
                if (p.code == code && p != this)
                {
                    p.timer = 2.0f;
                    Vector3 position = p.gameObject.transform.position;
                    other.gameObject.transform.position = position;
                }
            }
        }
    }
}
