﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public float speed;

	void Start ()
    {
        rigidbody.velocity = transform.forward * speed;
	}
}
