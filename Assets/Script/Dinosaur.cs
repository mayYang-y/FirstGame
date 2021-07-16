using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    public Rigidbody2D rb;
    public float runSpeed;
    public float jumpForce;
    // public float horizontalMove = 0f;

    public Collider2D topColider;
    public Collider2D bottomColider;
    public Collider2D rightColider;
    public Animator anim;
    public LayerMask ground;

    public GameManager gameManager;
    public Score score;
    AudioSource audioSource;

    private void Start() {
        rightColider.enabled = false;
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){

        Movement();

        Crouch();
    }

    void Movement(){
        // horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        // Debug.Log(Input.GetButtonDown("Jump"));
        if (Input.GetButtonDown("Jump") && bottomColider.IsTouchingLayers(ground)){
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            audioSource.Play();
        }
    }

    void Crouch(){
        if (Input.GetButtonDown("Crouch")){
            anim.SetBool("isCrouching", true);
            topColider.enabled = false;// 上半身方塊消失
            rightColider.enabled = true;// 右半身出現
        }else if (Input.GetButtonUp("Crouch")){
            anim.SetBool("isCrouching", false);
            topColider.enabled = true;// 上半身方塊出現
            rightColider.enabled = false;// 右半身消失
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "obstacle"){
            gameManager.GameOver();
            anim.SetBool("isGameOver", true);
            score.setHiScore();
        }
    }
}
