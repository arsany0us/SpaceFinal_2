using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private Animator anim;
    public bool isOnGround = true;
    public Transform groundCheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            Debug.Log("touching the ground");
            anim.SetTrigger("Ground");

        }
        if (other.gameObject.name != "Ground")
        {
            Debug.Log("Flying");
            anim.SetTrigger("Fly");
        }
    }
}
