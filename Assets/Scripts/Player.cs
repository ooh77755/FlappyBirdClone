using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float upwardsForce = 1000f;

    bool isAlive = true;

    Rigidbody2D rb;
    CircleCollider2D myCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            MakeCopterFly();
        }

        else if (!isAlive)
        {
            return;
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
        }
    }
}
