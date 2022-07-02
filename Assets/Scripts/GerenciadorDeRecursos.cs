using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GerenciadorDeRecursos : MonoBehaviour
{
    [System.Serializable]
    private class RecursosInspetor
    {
        [SerializeField]
        private Recurso recurso;
        [SerializeField]
        private float quantidadeInicial;
        [SerializeField]
        private UnityEvent eventosRecurso;

        public Recurso getRecurso => recurso;
        public float getQuantidadeInicial => quantidadeInicial;
        public UnityEvent getEventosRecurso => eventosRecurso;
    }

    [SerializeField]
    private RecursosInspetor[] recursosInspetor;


    private void Start()
    {
        for(int i=0;i<recursosInspetor.Length;i++)
        {
            recursosInspetor[i].getRecurso.setQuantidade(this, recursosInspetor[i].getQuantidadeInicial) ;
            if (recursosInspetor[i].getRecurso.getIncrementarComOTempo)
            {
                StartCoroutine("corrotinaRecursos", i);
            }
        }
    }
    IEnumerator corrotinaRecursos(int index)
    {
        yield return new WaitForSeconds(recursosInspetor[index].getRecurso.getTempoDeIncremento);
        recursosInspetor[index].getRecurso.incrementar(this);
        recursosInspetor[index].getEventosRecurso.Invoke();
        StartCoroutine("corrotinaRecursos", index);
    }
 
}
