using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour {
    private int puntos;
    private TextMeshProUGUI texto;

    private void Start() {
        texto = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        texto.text = puntos.ToString();
    }

    public int getPuntos() {
        return puntos;
    }

    public void SumarPuntos(int puntosExtra) {
        puntos += puntosExtra;
    }

}
