using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	// Use this for initialization
	void Start () {
        fade();
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        fade();
    }

    void fade()
    {
        Color tmp = GetComponent<SpriteRenderer>().color;
        tmp.a = tmp.a - (float)0.1;
        GetComponent<SpriteRenderer>().color = tmp;
    }
}
