using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public GameObject explosion;

    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "Plano") {

            Debug.Log("El enemigo ha caído al suelo");
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(gameObject);
            //Destroy(animExplosion, 1);
        }
    }

}
