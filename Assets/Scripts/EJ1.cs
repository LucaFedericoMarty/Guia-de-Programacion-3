//Definir una función que escriba en consola “Hola Mundo!” al ser invocada.
//Invocar la función al presionar la barra espaciadora.

//Definir una función que escriba en consola la cadena pasada por parámetro.

//Definir una función que concatene y muestre en consola un string y un int pasados por parámetros.

//Recibe un float por parámetro y lo procesa para devolver la parte entera como un string.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1 : MonoBehaviour
{
    int edad = 35;

    // Start is called before the first frame update
    void Start()
    {
        ParametroWrite("La chain de texto es esta");

        ConcatenacionDatos("Mi edad es de " , edad);

        Debug.Log(floatRedondearString(2.3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HolaMundo();
        }
    }

    void HolaMundo()
    {
        Debug.Log("Hola Mundo");
    }

    void ParametroWrite(string cadena)
    {
        Debug.Log(cadena);
    }

    void ConcatenacionDatos(string concat1, int concat2)
    {
        string mensaje = concat1 + concat2;
        Debug.Log(mensaje);
    }

    string floatRedondearString(float redondear)
    {
        Mathf.Round(redondear);
        string redondeadoF = redondear.ToString();
        return redondeadoF;
    }
}

