using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecursoFisico : MonoBehaviour
{
    [SerializeField]
    private Recurso recursoAAumentar;
    [SerializeField]
    private float tempoDeIncremento = 1;
    [SerializeField]
    private int incremento = 1;
    [SerializeField]
    private int quantidadeLocal = 0;
    [SerializeField]
    private int quantidadeMaxima = 2000;
    private InstanciadorDeMinerios pai;
    [SerializeField]
    private TextMeshProUGUI IndicadorDeQuantidade;
    [SerializeField]
    private Color corRecursoCheio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("corrotinaIncrementoQuantidadeRecursoLocal");
        if (IndicadorDeQuantidade != null)
        {
            IndicadorDeQuantidade.text = quantidadeLocal.ToString();
        }
    }

    public void setPai(InstanciadorDeMinerios novoPai)
    {
        pai = novoPai;
    }

    public void coletar()
    {
        recursoAAumentar.somarQuantidade(this, quantidadeLocal);
    }

    public void mandarPaiCriarOutroFilho()
    {
        pai.criarRecursoColeta();
    }

    // Update is called once per frame
    IEnumerator corrotinaIncrementoQuantidadeRecursoLocal()
    {
        yield return new WaitForSeconds(tempoDeIncremento);
        if (quantidadeLocal < quantidadeMaxima)
        {
            quantidadeLocal += incremento;
            if (IndicadorDeQuantidade != null)
            {
                IndicadorDeQuantidade.text = quantidadeLocal.ToString();
                if(quantidadeLocal>=quantidadeMaxima)
                {
                    IndicadorDeQuantidade.color = corRecursoCheio;
                }
            }
            StartCoroutine("corrotinaIncrementoQuantidadeRecursoLocal");
        }
    }
}
