using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colonia : MonoBehaviour
{

    public int alumnosInfantiles;
    public int alumnosJuveniles;

    void Start()
    {

        if (alumnosInfantiles < 10 || alumnosInfantiles > 100)
        {
            Debug.Log("Numero invalido de alumnos infantiles. Debe ser entre 10 y 100.");
            return;
        }

        if (alumnosJuveniles < 20 || alumnosJuveniles > 100)
        {
            Debug.Log("Numero invalido de alumnos juveniles. Debe ser entre 20 y 100.");
            return;
        }


        int profesoresInfantiles = alumnosInfantiles / 10;
        int sobrantesInfantiles = alumnosInfantiles % 10;

        int profesoresJuveniles = alumnosJuveniles / 20;
        int sobrantesJuveniles = alumnosJuveniles % 20;

        int totalProfesores = profesoresInfantiles + profesoresJuveniles;


        int coordinadores = totalProfesores / 5;
        int resto = totalProfesores % 5;

        if (resto > 0)
        {
            coordinadores = coordinadores + 1;
        }


        Debug.Log("Profesores requeridos: " + totalProfesores);
        Debug.Log("Coordinadores requeridos: " + coordinadores);

        if (sobrantesInfantiles > 0 || sobrantesJuveniles > 0)
        {
            Debug.Log("Alumnos que quedaron fuera de la asignación:");
            if (sobrantesInfantiles > 0)
            {
                Debug.Log(sobrantesInfantiles + " alumnos infantiles");
            }
            if (sobrantesJuveniles > 0)
            {
                Debug.Log(sobrantesJuveniles + " alumnos juveniles");
            }
        }
        else
        {
            Debug.Log("Todos los alumnos fueron asignados.");
        }
    }


// Update is called once per frame
void Update()
    {
        
    }
}
