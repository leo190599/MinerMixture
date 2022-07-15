using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NovoTipoDeEstacaoDeVenda",menuName ="tipoEstacaoDeVenda")]
public class TipoEstacaoDeVenda : ScriptableObject
{
    [SerializeField]
    private float tempoParaVenda = .5f;
    [SerializeField]
    private Recurso recursoASerComprado;
    [SerializeField]
    private Recurso recursoASerVendido;
    [SerializeField]
    private float quantidadeASerVendida = 10;

    public float getQuantidadeASerVendida => quantidadeASerVendida;
    public float getTempoParaVenda => tempoParaVenda;
    public Recurso getRecursoASerComprado => recursoASerComprado;
    public Recurso getRecursoASerVendido => recursoASerVendido;
}
