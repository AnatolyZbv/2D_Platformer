using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float speedX = 1f;
    private bool isGround = false;
    private bool isJump = false;
     private float horizontal = 0f;
     private Rigidbody2D rb;
   
    const float speedXMultiplier = 250f;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
  
    }
   void Update() {
      horizontal = Input.GetAxis("Horizontal"); //-1...+1
        if(Input.GetKey(KeyCode.W) && isGround) {
            isJump = true;
        }
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(horizontal * speedX * speedXMultiplier * Time.fixedDeltaTime, rb.velocity.y);
        
        if(isJump) {
            rb.AddForce(new Vector2(0f, 420f));
            isGround = false;
            isJump = false;
        }
    }

    void OnCollisionEnter2D (Collision2D other) {
        if(other.gameObject.CompareTag("Ground")) {
            isGround = true;
        }
    }
}
