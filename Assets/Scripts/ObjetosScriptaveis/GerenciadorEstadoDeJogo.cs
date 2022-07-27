using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="NovoGerenciadorDeEstado",menuName ="GerenciadorDeEstado")]
public class GerenciadorEstadoDeJogo : ScriptableObject
{
    public const int jogando = 0;
    public const int pausado = 1;
    public const int gameOver = 2;
    public const int venceu = 3;
    [SerializeField]
    private int estado=jogando;

    public UnityAction eventosPausar;
    public UnityAction eventosDespausar;
    public UnityAction eventosGameOver;
    public UnityAction eventosVenceu;


    private void Awake()
    {
        trocarEstado(jogando);
    }

    public void trocarEstado(int novoEstado)
    {
        if(novoEstado==jogando)
        {
            estado = jogando;
            Time.timeScale = 1;
            if (eventosDespausar != null)
            {
                eventosDespausar.Invoke();
            }
        }
        else if(novoEstado== pausado)
        {
            Time.timeScale = 0;

            estado = pausado;
            if (eventosPausar != null)
            {
                eventosPausar.Invoke();
            }
        }
        else if(novoEstado==gameOver)
        {
            estado = gameOver;
            Time.timeScale = 0;
            if (eventosGameOver != null)
            {
                eventosGameOver.Invoke();
            }
        }
        else if(novoEstado==venceu)
        {
            estado = venceu;
            Time.timeScale = 0;
            if(eventosVenceu!=null)
            {
                eventosVenceu.Invoke();
            }
        }
        else
        {
            Debug.LogError("Estado nao existe");
        }
    }

    public int getEstado => estado;
}
