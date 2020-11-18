﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = Random.Range(60f, 90f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }
}
