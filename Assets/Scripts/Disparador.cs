using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disparador : MonoBehaviour
{
    RaycastHit hit;

    public GameObject arCamera;
    public GameObject[] enemigos;
    public GameObject proyectil;

    public float velocidadDisparo = 1000.0f;
    public float time;
    public float tiempoAleatorio;

    private bool empezarGenerar = false;

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
        if (tiempoAleatorio <= 0 && empezarGenerar) {
            CrearEnemigo();
            tiempoAleatorio = Random.Range(0, 3);
        }
    }

    public void CrearEnemigo() {
        Debug.Log("Nuevo enemigo");
        Vector3 posicionEnemigo = new Vector3(Random.Range(-5,5), Random.Range(3, 4), Random.Range(3, 8));
        var enemigoGenerado = enemigos[Random.Range(0, enemigos.Length)];
        var nuevoEnem = Instantiate(enemigoGenerado, posicionEnemigo, Quaternion.identity);
        Destroy(nuevoEnem, 15);
    }

    public void DispararEnemigo() {
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            GameObject nuevaBala = Instantiate(proyectil, arCamera.transform.position, arCamera.transform.rotation) as GameObject;
            nuevaBala.GetComponent<Rigidbody>().AddForce(arCamera.transform.forward * 2000);
            Destroy(nuevaBala, 3);
        //}
    }

    public void EmpezarGenerarEnemigos() {
        empezarGenerar = true;
    }

    public void AcabarGenerarEnemigos() {
        empezarGenerar = false;
    }
}
