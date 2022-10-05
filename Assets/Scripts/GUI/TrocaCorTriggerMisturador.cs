using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrocaCorTriggerMisturador : MonoBehaviour
{
    [SerializeField]
    private TrocaCorImagem trocador;
    [SerializeField]
    private Receita receita;
    [SerializeField]
    private int indexCorSucesso=0;
    [SerializeField]
    private int indexCorFalha = 1;
    [SerializeField]
    private UnityEvent eventosAuxiliares;

    public void inscrever()
    {
        receita.EventosMistura += TrocaCorSucesso;
        receita.EventosFalhaMistura += trocaCorFalha;
    }

    public void desinscrever()
    {
        receita.EventosMistura -= TrocaCorSucesso;
        receita.EventosFalhaMistura -= trocaCorFalha;
    }

    private void OnDisable()
    {
        desinscrever();
    }
    // Start is called before the first frame update
    public void TrocaCorSucesso()
    {
        trocador.trocarCor(indexCorSucesso);
        if(eventosAuxiliares!=null)
        {
            eventosAuxiliares.Invoke();
        }
    }

    public void trocaCorFalha()
    {
        trocador.trocarCor(indexCorFalha);
    }
}
