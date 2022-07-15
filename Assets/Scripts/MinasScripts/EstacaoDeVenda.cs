using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstacaoDeVenda : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TipoEstacaoDeVenda tipoEstacao;


    public void ativarVenda()
    {
        StartCoroutine("vendaTemporizada");
    }
    public void desativarVenda()
    {
        StopCoroutine("vendaTemporizada");
    }

    IEnumerator vendaTemporizada()
    {
        yield return new WaitForSeconds(tipoEstacao.getTempoParaVenda);
        if(tipoEstacao.getRecursoASerVendido.getQuantidade>=tipoEstacao.getQuantidadeASerVendida)
        {
            tipoEstacao.getRecursoASerVendido.somarQuantidade(this,-tipoEstacao.getQuantidadeASerVendida);
            tipoEstacao.getRecursoASerComprado.somarQuantidade(this, tipoEstacao.getQuantidadeASerVendida * tipoEstacao.getRecursoASerVendido.getValorEmOuro);
        }
        StartCoroutine("vendaTemporizada");
    }
}
