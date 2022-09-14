using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoRecursosTela : MonoBehaviour
{
    [SerializeField]
    private Recurso recursoAServisto;
    private Animator anim;
    private float quantidadeAtualDeRecursos;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        quantidadeAtualDeRecursos = recursoAServisto.getQuantidade;    
    }
    private void OnEnable()
    {
        recursoAServisto.eventosASeremChamados += animarMudancaRecurso;
    }

    private void OnDisable()
    {
        recursoAServisto.eventosASeremChamados -= animarMudancaRecurso;
    }

    public void animarMudancaRecurso()
    {
        if(recursoAServisto.getQuantidade>quantidadeAtualDeRecursos)
        {
            anim.SetInteger("Incremento", 1);
        }
        else if (recursoAServisto.getQuantidade < quantidadeAtualDeRecursos)
        {
            anim.SetInteger("Incremento", -1);
        }
        quantidadeAtualDeRecursos = recursoAServisto.getQuantidade;

    }
    public void setIncremento(int novoIncremento)
    {
        anim.SetInteger("Incremento", novoIncremento);
    }

}
