using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coso : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject[] enemigos;
    RaycastHit hit;
    public GameObject objeto;
    public GameObject explosion;
    public GameObject proyectil;
    public float velocidadDisparo = 2000.0f;

    public float time;
    public float tiempoAleatorio;
    public GameObject enemigoAleatorio;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -0.2F, 0);
        tiempoAleatorio = Random.Range(0, 3);   
    }

    // Update is called once per frame
    void Update()
    {

        // Crear enemigo
        tiempoAleatorio -= Time.deltaTime;
        if (tiempoAleatorio <= 0) {
            CrearEnemigo();
            tiempoAleatorio = Random.Range(0, 3);
        }

        // Destruir enemigo
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)) {
                if (hit.transform.tag == "Enemigo") {
                    Destroy(hit.transform.gameObject);
                    Instantiate(objeto, hit.transform.position, hit.transform.rotation);
                }
            }
        }
        
    }

    public void CrearEnemigo() {
        Debug.Log("okk2");
        Vector3 posicionEnemigo = new Vector3(Random.Range(-5,5), Random.Range(3, 4), Random.Range(3, 8));
        Instantiate(enemigoAleatorio, posicionEnemigo, Quaternion.identity);
    }
}
