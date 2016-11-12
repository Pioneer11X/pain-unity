using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float Speed = 10f;
    private float movex = 0f;
    private float movey = 0f;
    private Rigidbody2D wololo;

    // Use this for initialization
    void Start () {
         wololo = GetComponent<Rigidbody2D>();
        //Debug.Log("Kappa");
    }
	
	// Update is called once per frame
	void Update () {
      
    }

    void FixedUpdate()
    {
        movex = Input.GetAxis("Horizontal");
        //movey = Input.GetAxis("Vertical");
        wololo.velocity = new Vector2(movex * Speed, wololo.velocity.y);

    }
}
