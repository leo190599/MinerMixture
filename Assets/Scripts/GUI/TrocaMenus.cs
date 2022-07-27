using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaMenus : MonoBehaviour
{
    [SerializeField]
    private GameObject menuAtivo;
    [SerializeField]
    private GameObject[] menus;
    [SerializeField]
    private GerenciadorEstadoDeJogo gerenciadorEstado;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject g in menus)
        {
            if(menuAtivo!=g)
            {
                g.SetActive(false);
            }
            else
            {
                g.SetActive(true);
            }
        }
    }

    private void OnEnable()
    {
        if (gerenciadorEstado!=null)
        {
            gerenciadorEstado.eventosDespausar += setarMenuJogando;
            gerenciadorEstado.eventosPausar += setarMenuPausa;
            gerenciadorEstado.eventosGameOver += setarMenuGameOver;
            gerenciadorEstado.eventosVenceu += setarMenuVenceu;
        }
        else
        {
            Debug.LogWarning("Não há um gerenciador de estado");
        }
    }
    public void OnDisable()
    {
        if (gerenciadorEstado != null)
        {
            gerenciadorEstado.eventosDespausar -= setarMenuJogando;
            gerenciadorEstado.eventosPausar -= setarMenuPausa;
            gerenciadorEstado.eventosGameOver -= setarMenuGameOver;
            gerenciadorEstado.eventosVenceu -= setarMenuVenceu;
        }
        else
        {
            Debug.LogWarning("Não há um gerenciador de estado");
        }
    }

    public void setarMenuJogando()
    {
        troca(0);
    }

    public void setarMenuPausa()
    {
        troca(1);
    }

    public void setarMenuGameOver()
    {
        troca(2);
    }

    public void setarMenuVenceu()
    {
        troca(3);
    }

    public void troca(int indexMenuAAtivar)
    {
        menuAtivo.SetActive(false);
        menuAtivo = menus[indexMenuAAtivar];
        menuAtivo.SetActive(true);
    }
}
