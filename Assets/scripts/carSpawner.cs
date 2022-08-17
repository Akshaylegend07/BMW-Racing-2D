using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;
    public float maxPos = 2.5f;
    public float delayTimer = 2f;
    float timer;
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update(){
        timer -= Time.deltaTime;
        if (timer <= 0) {

        Vector3 carPos = new Vector3(Random.Range(-2.4f,2.5f),transform.position.y,transform.position.z);
        Instantiate (car, carPos, transform.rotation);
        timer = delayTimer;
    }
    }
}