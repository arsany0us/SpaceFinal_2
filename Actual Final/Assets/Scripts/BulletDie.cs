using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDie : MonoBehaviour
{
    public float dieTime;
    public GameObject diePEffect;
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
           
            Die();
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(dieTime);
        Die();
    }

    void Die()
    {
        if (diePEffect != null)
        {
            Instantiate(diePEffect, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
