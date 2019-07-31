using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{

    private bool ringActive = false;

    public void ActivateRing()
    {
        ringActive = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the ring is active
        // Tell the objective script that is has been passed through
        if (ringActive && other.gameObject.tag == "Player")
        {
            Destroy(gameObject, 5.0f);
        }
    }
}
//rings[ringPassed].GetComponent<Animator>().SetTrigger("collectionTrigger");