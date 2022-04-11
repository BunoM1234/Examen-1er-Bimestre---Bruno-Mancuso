using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJANIMALITOS : MonoBehaviour
{
    public string codigoCate;
    public int Dias;
    int comidagatos = 300;
    int comidaperrosp = 400;
    int comidaperrosg = 700;
    // Start is called before the first frame update
    void Start()
    {
        if (codigoCate == "PP")
        {
            int Res1 = Dias * comidaperrosp;
            Debug.Log("Para ese período se necesitan " + Res1 + " gramos de alimento.");
            int valorPP = Res1 / 100;
            int resValorPP = valorPP * 80;
            Debug.Log("El precio equivalente a esa cantidad de comida es de $" + resValorPP);
        }
        else if (codigoCate == "PG")
        {
            int Res2 = Dias * comidaperrosg;
            Debug.Log("Para ese período se necesitan " + Res2 + " gramos de alimento.");
            int valorPG = Res2 / 100;
            int resValorPG = valorPG * 80;
            Debug.Log("El precio equivalente a esa cantidad de comida es de $" + resValorPG);
        }
        else if (codigoCate == "G")
        {
            int Res3 = Dias * comidagatos;
            Debug.Log("Para ese período se necesitan " + Res3 + " gramos de alimento.");
            int valorG = Res3 / 100;
            int resValorG = valorG * 80;
            Debug.Log("El precio equivalente a esa cantidad de comida es de $" + resValorG);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
