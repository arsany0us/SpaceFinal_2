using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float upForce = 700f;

    public bool fly = false;
    public bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
    public bool isOnGround = true;

    AudioSource audioSource;
    public AudioClip coinSound;

    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if ((Input.GetKey(KeyCode.Space)))
            {

                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                
                
                    anim.SetTrigger("Fly");
             
               
            }
            else
            {
                anim.SetTrigger("Ground");
            }
            
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            rb2d.velocity = Vector2.zero;
            isDead = true;
            GameControl.instance.GameOver();
        }

      
        if (other.gameObject.CompareTag("Enemy"))
        {
            rb2d.velocity = Vector2.zero;
            GameControl.instance.GameOver();
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            PlaySound(coinSound);
            Destroy(other.gameObject);
        }
    

    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
  
   
}


