using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] AudioClip deathSFX;
    Vector2 deathKick = new Vector2(250f, -250f);
    float upwardsForce = 1000f;

    bool isAlive = true;

    Rigidbody2D rb;
    CircleCollider2D myCollider;
    AudioSource myAudioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            MakeCopterFly();
        }

        CopterCrash();
    }

    private void MakeCopterFly()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector2.up * upwardsForce * Time.deltaTime);
        }
    }

    private void CopterCrash()
    {
        if (myCollider.IsTouchingLayers(LayerMask.GetMask("Pipe")))
        {
            isAlive = false;
            rb.velocity = deathKick;
            myAudioSource.PlayOneShot(deathSFX, 0.5f);
        }
    }
}
