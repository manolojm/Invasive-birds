using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
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
        if (collision.transform.tag == "Plano") {

            Debug.Log("choca");
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject);
        }
    }

}
