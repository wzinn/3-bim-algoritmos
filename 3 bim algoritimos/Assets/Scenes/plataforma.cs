using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    private Rigidbody2D rb;

    private float falldelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(0.2f);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, falldelay);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player")) ;
        {
            StartCoroutine("Fall");
        }
}

    // Update is called once per frame
}
