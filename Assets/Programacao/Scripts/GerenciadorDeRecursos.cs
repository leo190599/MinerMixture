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
    private GameObject[] TextosOuro;
    private List<ITextoTela> ITextosOuro;
    // Start is called before the first frame update
    void Start()
    {
        ITextosOuro = new List<ITextoTela>();
        StartCoroutine("corroTinaOuro");
        foreach(GameObject g in TextosOuro)
        {
            ITextoTela temp = g.GetComponent<ITextoTela>();
            if(temp!=null)
            {
                ITextosOuro.Add(temp);
            }
            else
            {
                Debug.LogError("Todos os objetos devem conter um componente que possua a interface ITextoTela, o objeto "+g+" não possui");
            }
        }
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
        foreach(ITextoTela t in ITextosOuro)
        {
            t.atualizarValor(Ouro);
       }
        StartCoroutine("corroTinaOuro");
    }
}
