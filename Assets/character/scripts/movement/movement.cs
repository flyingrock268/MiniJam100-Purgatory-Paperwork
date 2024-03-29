﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class movement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rb2D;

    public float speed;
    public bool followPlayer;
    public bool canMove = true;

    [HideInInspector]
    public Vector2 rawMovement;

}
