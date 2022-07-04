using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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

    public UnityAction eventosASeremChamados;
    private void Awake()
    {
        if (eventosASeremChamados != null)
        {
            eventosASeremChamados.Invoke();
        }
    }

    public void setIncremento(Object chamador,float quantidade)
    {
        incremento = quantidade;
    }

    public void incrementarIncremento(Object chamador,float quantidade)
    {
        incremento += quantidade;
    }
    public void comprar(Object chamador,float preco)
    {
        if (quantidade >= preco)
        {
            quantidade -= preco;
            if (eventosASeremChamados != null)
            {
                eventosASeremChamados.Invoke();
            }
        }
    }
    public void setQuantidade(Object chamador,float quantidade)
    {
        this.quantidade = quantidade;
        if (eventosASeremChamados!=null)
        {
            eventosASeremChamados.Invoke();
        }
    }
    public void incrementar(Object chamador)
    {
        quantidade += incremento;
        if (eventosASeremChamados != null)
        {
            eventosASeremChamados.Invoke();
        }
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
