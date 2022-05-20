using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLaser : MonoBehaviour
{
    public float shootSpeed, shootTimer;

    private bool isShooting;

    public Transform shootPos;
    public GameObject bullet;
    public GameObject diePEffect;

    AudioSource audioSource;
    public AudioClip laserSound;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isShooting = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isShooting)
        {

            StartCoroutine(Shoot());
            PlaySound(laserSound);
        }
    }

    IEnumerator Shoot()
    {
        isShooting = true;
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * Time.fixedDeltaTime, 0f);
        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Die();
        }
        if (collisionGameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Die();
        }
    }

    void Die()
    {
        if (diePEffect != null)
        {
            Instantiate(diePEffect, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
