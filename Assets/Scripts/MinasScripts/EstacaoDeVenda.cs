using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EstacaoDeVenda : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TipoEstacaoDeVenda tipoEstacao;
    [SerializeField]
    private UnityEvent eventoFalhaDeCompra;


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
        if (!(tipoEstacao.getRecursoASerVendido.getQuantidade >= tipoEstacao.getQuantidadeASerVendida))
        {
            if (eventoFalhaDeCompra != null)
            {
                eventoFalhaDeCompra.Invoke();
            }
        }
        yield return new WaitForSeconds(tipoEstacao.getTempoParaVenda);
        if (tipoEstacao.getRecursoASerVendido.getQuantidade >= tipoEstacao.getQuantidadeASerVendida)
        {
            tipoEstacao.getRecursoASerVendido.somarQuantidade(this, -tipoEstacao.getQuantidadeASerVendida);
            tipoEstacao.getRecursoASerComprado.somarQuantidade(this, tipoEstacao.getQuantidadeASerVendida * tipoEstacao.getRecursoASerVendido.getValorEmOuro);
        }
        StartCoroutine("vendaTemporizada");
    }
}
