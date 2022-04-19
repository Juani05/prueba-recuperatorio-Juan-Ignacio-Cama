using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejhelado : MonoBehaviour
{
    public string gustodehelado;
    public float gramosdehelado;
    // Start is called before the first frame update
    void Start()
    {
        float precioheladonormal = gramosdehelado * 0.5f;
        float preciodeheladofrutillas = precioheladonormal * 0.10f;
        if (gustodehelado != "ddl" || gustodehelado != "fru" || gustodehelado != "cho")
        {
            Debug.Log("No es posible ingresar esta gusto de helado, para ingresar su gusto de helado escriba ddl,fru o cho");
        }
        if (gramosdehelado < 250 || gramosdehelado > 3000)
        {
            Debug.Log("No es posible realizar esta operación, ingrese una cantidad de gramos entre 250 y 3000");
        }
        else if (gustodehelado == "ddl" || gustodehelado == "cho")
        {
            Debug.Log("El precio por su helado es de pesos " + precioheladonormal);
        }
        else if (gustodehelado == "fru")
        {
            Debug.Log("El precio de su helado es de pesos " + preciodeheladofrutillas);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
