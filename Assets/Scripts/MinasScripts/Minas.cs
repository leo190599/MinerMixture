using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Minas : MonoBehaviour
{
    [System.Serializable]
    private class CustoMina
    {
        [SerializeField]
        private Recurso recurso;
        [SerializeField]
        private float custo;

        public Recurso getRecurso => recurso;
        public bool checarPossibilidadeDeCompra => recurso.getQuantidade >= custo;
        public float getCusto => custo;
    }
    

    [SerializeField]
    private UnityEvent eventoAtivar;
    [SerializeField]
    private UnityEvent eventoFalhaAtivar;
    private bool ativo = false;
    [SerializeField]
    private Material MaterialDesativado, MaterialAtivado;
    [SerializeField]
    private CustoMina[] custosMinas;
    [SerializeField]
    private MeshRenderer renderizador;
    // Start is called before the first frame update
    void Start()
    {
        renderizador = GetComponent<MeshRenderer>();
        renderizador.material = MaterialDesativado;
    }
    public void Ativar()
    {
        renderizador.material = MaterialAtivado;
        ativo = true;
        eventoAtivar.Invoke();
    }

    public void Desativar()
    {
        renderizador.material = MaterialDesativado;
        ativo = false;
    }

    public void comprar()
    {
        if (!ativo)
        {
            foreach (CustoMina c in custosMinas)
            {
                if (!c.checarPossibilidadeDeCompra)
                {
                    if(eventoFalhaAtivar!=null)
                    {
                        eventoFalhaAtivar.Invoke();
                    }
                    return;
                }
            }
            foreach (CustoMina c in custosMinas)
            {
                c.getRecurso.comprar(this, c.getCusto);
            }
            Ativar();
        }
    }
}
