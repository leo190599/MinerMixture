using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misturador : MonoBehaviour
{
    [SerializeField]
    private Receita mistura;
    public void setMistura(Receita receita)
    {
        this.mistura = receita;
    }
    public Receita getMistura => mistura;

    public void comecarMistura(Receita mistura)
    {
        this.mistura = mistura;
        StartCoroutine("corrotinaMistura");
    }

    public void pararMistura()
    {
        StopCoroutine("corrotinaMistura");
    }

    IEnumerator corrotinaMistura()
    {
        yield return new WaitForSeconds(mistura.getTempoDeMistura);
        mistura.misturar(this);
        StartCoroutine("corrotinaMistura");

    }
}
