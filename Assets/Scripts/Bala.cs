using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public GameObject explosion;
    public int puntos;
    public Puntuacion puntuacion;

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Disparo acertado");
        puntos = 0;

        Destroy(collision.transform.gameObject);
        Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        Destroy(gameObject.GetComponent<GameObject>());
        //Destroy(animExplosion, 1);

        if (collision.transform.tag == "Enemigo") {
            puntos = 100;
        } else {
            puntos = -50;
        }

        puntuacion.SumarPuntos(puntos);
    }
}
