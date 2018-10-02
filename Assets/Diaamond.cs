using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diaamond : MonoBehaviour
{
    [Range(0,720)]
    public float rotationspeed;
    public SpriteRenderer rend;
    public Color newcolor;
    public Transform other;
	// Use this for initialization
	void Start ()
    {
        rend.color = newcolor;
        rend.color = new Color(1f, 0.5f, 0.7f);
        //other.position = new Vector3(3, 4, other.position.z);


	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, --rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
        }
        transform.Translate(5f * Time.deltaTime, 0, 0,Space.Self);


	}
}
