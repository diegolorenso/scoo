﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoxPencil : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bot"))
        {
            other.gameObject.SetActive(false);
        }
    }
    }