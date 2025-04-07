using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{
    //1. definición de variables

    public int cantidadDias;
    public string codigoAnimal;
    int gramosComidaTotal;
    int racionGatos = 300;
    int racionPerrosPeque = 400;
    int racionPerrosGrandes = 700;
    int racionAnimalActual;
    float costoAlimento;
    float precioPorCienGramos = 80;

    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso de datos (más adelante)
        if (cantidadDias < 3)
        {
            Debug.Log("Cantidad de días no válida.");
            return;
        }

            if (codigoAnimal == "G" || codigoAnimal == "g")
            {
                racionAnimalActual = racionGatos;
            }
            else if (codigoAnimal == "PP" || codigoAnimal == "pp")
            {
                racionAnimalActual = racionPerrosPeque;
            }
            else if (codigoAnimal == "PG" || codigoAnimal == "pg")
            {
                racionAnimalActual = racionPerrosGrandes;
            }else
            {
                Debug.Log("Código no válido");
                return;
            }


            //3. Procesamiento de los datos

            gramosComidaTotal = racionAnimalActual * cantidadDias;

            costoAlimento = gramosComidaTotal / 100 * precioPorCienGramos;

            //4. Mostrar resultado

            Debug.Log("Para ese periodo se necesitan " + gramosComidaTotal +
                " gramos de alimento");
            Debug.Log("Costo alimento: $" + costoAlimento);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
