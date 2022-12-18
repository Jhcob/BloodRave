using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToHell : MonoBehaviour
{

    public GameObject startMesh, transitionMesh;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("transition");
        startMesh.gameObject.SetActive(false);
        transitionMesh.gameObject.SetActive(true);
    }
}
