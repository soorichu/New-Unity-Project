﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//동작이 들어가면 MonoBehaviour 클래스를 상속받아야 합니다.
public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null){
                playerController.Die();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
