using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotationSpeed = 1.0f; //Velocidade do giro do objeto

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        //Gira o objeto em torno do eixo y de acordo com a velocidade configurada
        //e o tempo entre as chamadas do update()
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
