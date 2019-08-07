using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private float deathTime;
    private float deathDuration = 2;

    public GameObject deathExplosion;

    private void OnTriggerEnter(Collider other)
    {
        // Set a death timestamp
        deathTime = Time.time;

        // Player explosion effect
        GameObject go = Instantiate(deathExplosion) as GameObject;
        go.transform.position = transform.position;

        // Hide player mesh
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
        Debug.Log("Hit");
    }
}
