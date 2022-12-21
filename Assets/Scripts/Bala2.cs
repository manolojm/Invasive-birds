using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala2 : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("prueba");
        
        if (collision.transform.tag == "Enemigo") {
            Destroy(collision.transform.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject.GetComponent<GameObject>());
            //Destroy(explosion);
        }
    }
}
