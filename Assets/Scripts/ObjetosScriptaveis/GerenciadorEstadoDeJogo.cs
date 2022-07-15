using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="NovoGerenciadorDeEstado",menuName ="GerenciadorDeEstado")]
public class GerenciadorEstadoDeJogo : ScriptableObject
{
    public const int jogando = 0;
    public const int pausado = 1;
    [SerializeField]
    private int estado=jogando;

    public UnityAction eventosPausar;
    public UnityAction eventosDespausar;


    private void Awake()
    {
        despausar(this);
    }

    public void pausar(Object chamador)
    {
        Time.timeScale = 0;

        estado = pausado;
        if(eventosPausar!=null)
        {
            eventosPausar.Invoke();
        }
    }

    public void despausar(Object chamador)
    {
        Time.timeScale = 1;
        estado = jogando;
        if(eventosDespausar!=null)
        {
            eventosDespausar.Invoke();
        }
    }

    public void trocarEstado(Object chamador)
    {
        if(estado==jogando)
        {
            pausar(this);
        }
        else
        {
            despausar(this);
        }
    }

    public int getEstado => estado;
}
