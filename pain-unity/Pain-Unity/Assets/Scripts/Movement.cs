using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float Speed = 100f;
	public float Thrust = 100f;

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

		if (Input.GetKeyDown ("space")) {
			Vector2 force = new Vector2(0f, Thrust);
			GetComponent<Rigidbody2D>().AddForce(force);
		}

			movex = Input.GetAxis("Horizontal");
			//movey = Input.GetAxis("Vertical");
//			wololo.velocity = new Vector2(movex * Speed, wololo.velocity.y);
		if (movex != 0){
			wololo.AddForce(new Vector2(movex * Speed, 0));
		}

    }
}
