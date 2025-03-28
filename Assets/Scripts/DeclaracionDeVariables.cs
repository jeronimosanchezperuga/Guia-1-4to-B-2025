using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int edadUsuario;
    float sueldoUsuario;
    string domicilio;
    bool estaAprobado;

    // Start is called before the first frame update
    void Start()
    {
        //inicializo las variables
        edadUsuario = 45;
        sueldoUsuario = 1000.00f;
        domicilio =  "Libertador 6500";
        estaAprobado = true;

        //escribo las variables en consola
        Debug.Log(edadUsuario);
        Debug.Log(sueldoUsuario);
        Debug.Log(domicilio);
        Debug.Log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
