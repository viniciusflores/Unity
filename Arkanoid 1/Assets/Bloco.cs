using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {

    public Rigidbody2D rigidbody;
    public BoxCollider2D collider;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.constraints = new RigidbodyConstraints2D();
        collider.isTrigger = true;
    }
}
