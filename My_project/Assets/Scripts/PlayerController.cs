using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
  
    }
    void Update () {
      
    }
    void FixedUpdate() {
        rb.velocity = new Vector2(1f, rb.velocity.y);
    }
}
