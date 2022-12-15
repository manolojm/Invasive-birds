using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coso : MonoBehaviour
{
    public GameObject arCamera;
    RaycastHit hit;
    public GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)) {
                if (hit.transform.tag == "Enemigo") {
                    Destroy(hit.transform.gameObject);
                    Instantiate(objeto, hit.transform.position, hit.transform.rotation);
                }
            }
        }
        
    }
}
