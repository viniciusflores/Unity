using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

    public float Velocidade = 10.0f;
    public float HorizontalAxis;
    public Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        HorizontalAxis = Input.GetAxis ("Horizontal");
        rigidbody.velocity = new Vector2(Velocidade * HorizontalAxis, 0);
    }
}
