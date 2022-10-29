using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJuego : MonoBehaviour
{
    public GameObject[] enemigos;
    public Transform[] posiciones;

    private void Start()
    {
        enemigos[0].transform.position = posiciones[0].position;
    }
}
