using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeRecursos : MonoBehaviour
{
    [Header("Ouro")]
    [SerializeField]
    private int Ouro = 100;
    [SerializeField]
    private float IncrementadorDoOuro = 0;
    [SerializeField]
    private float TempoParaIncrementarOOuro = 1;
    [SerializeField]
    private TextoTela[] TextosOuro;
   
    void Start()
    {
        StartCoroutine("corroTinaOuro");
    }

    public void setOuro(int NovaQuantidadeDeOuro)
    {
        this.Ouro = NovaQuantidadeDeOuro;
    }
    public int getOuro()
    {
        return Ouro;
    }

    public void incrementarIncrementoDoOuro(float ValorASerSomado)
    {
        IncrementadorDoOuro += ValorASerSomado;
    }
    public float getIncrementoDoOuro()
    {
        return IncrementadorDoOuro;
    }

    IEnumerator corroTinaOuro()
    {
        yield return new WaitForSeconds(TempoParaIncrementarOOuro);
        Ouro += (int)IncrementadorDoOuro;
        foreach(TextoTela t in TextosOuro)
        {
            t.atualizarValor(Ouro);
       }
        StartCoroutine("corroTinaOuro");
    }
}
