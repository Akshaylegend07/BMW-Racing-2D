using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    // Start is called before the first frame update
    public float carSpeed;
    public float maxPos = 2.5f;
    Vector3 position;

    void Start()
    {
        position = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
        position.y += Input.GetAxis ("Vertical") * carSpeed * Time.deltaTime;
        position.x=Mathf.Clamp (position.x, -2.4f, 2.5f);
        position.y=Mathf.Clamp (position.y, -4.3f, 4.2f);
        transform.position = position;
    }
    void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Enemy car"){
			Destroy (gameObject);
		}
    }
}
