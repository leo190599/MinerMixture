using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassadorDeNIvel : MonoBehaviour
{
    [System.Serializable]
    public class recursosExigidos
    {
        [SerializeField]
        private Recurso recurso;
        [SerializeField]
        private int quantidade;

        public void setRecurso(object chamador, Recurso novoRecurso)
        {
            recurso = novoRecurso;
        }

        public void setQuantidade(Object chamador, int novaQuantidade)
        {
            quantidade = novaQuantidade;
        }

        public Recurso GetRecurso => recurso;

        public int GetQuantidade => quantidade;
    }

    [SerializeField]
    private recursosExigidos[] recursosParaPassar;
    [SerializeField]
    private GerenciadorEstadoDeJogo gerenciadorDeE;
   
    public void TentarPassarDeNivel()
    {
        foreach (recursosExigidos r in recursosParaPassar)
        {
            if(r.GetRecurso.getQuantidade<r.GetQuantidade)
            {
                return;
            }
        }
        gerenciadorDeE.trocarEstado(GerenciadorEstadoDeJogo.venceu);
    }
}
