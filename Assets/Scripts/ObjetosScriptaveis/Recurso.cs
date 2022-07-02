using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NovoRecurso", menuName = "Recuro")]
public class Recurso : ScriptableObject
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private Sprite imagem;
    [SerializeField]
    private float quantidade = 100;
    [SerializeField]
    private float valorEmOuro = 1;
    [SerializeField]
    private float incremento = 0;
    [SerializeField]
    private float tempoDeIncremento = 1;
    [SerializeField]
    private bool incrementarComOtempo;


    public void incrementarIncremento(Object chamador,float quantidade)
    {
        incremento += quantidade;
    }
    public void comprar(Object chamador,float preco)
    {
        if (quantidade >= preco)
        {
            quantidade -= preco;
        }
    }
    public void setQuantidade(Object chamador,float quantidade)
    {
        this.quantidade = quantidade;
    }
    public void incrementar(Object chamador)
    {
        quantidade += incremento;
    }
    public void setTempoDeIncremento(Object chamador, float tempo)
    {
        this.tempoDeIncremento = tempo;
    }
    public float getQuantidade => quantidade;
    public string getNome => nome;
    public float getIncremento => incremento;
    public Sprite getImagem => imagem;
    public float getValorEmOuro => valorEmOuro;
    public float getTempoDeIncremento => tempoDeIncremento;
    public bool getIncrementarComOTempo => incrementarComOtempo;
}
