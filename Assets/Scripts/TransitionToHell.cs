using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToHell : MonoBehaviour
{
    private Animator _animator;
    private GameObject _world;
    

   
    
    void Start()
    {
        _world = GameObject.Find("-- ENVIRONMENT");
        _animator = _world.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
            RenderSettings.fogColor = Color.red;
                
        Debug.Log("to hell!!");
        _animator.SetTrigger("toHell");
    }
}
