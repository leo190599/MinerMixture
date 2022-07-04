using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    [System.Serializable]
    private class OutputMina
    {
        [SerializeField]
        private Recurso recurso;
        [SerializeField]
        private float quantidade;

        public Recurso getRecurso => recurso;
        public float getQuantidade => quantidade;
    }
    private bool ativo = false;
    [SerializeField]
    private Material MaterialDesativado, MaterialAtivado;
    [SerializeField]
    private CustoMina[] custosMinas;
    [SerializeField]
    private OutputMina outputMina;
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
                    return;
                }
            }
            foreach (CustoMina c in custosMinas)
            {
                c.getRecurso.comprar(this, c.getCusto);
            }
            outputMina.getRecurso.incrementarIncremento(this, outputMina.getQuantidade);
            Ativar();
        }
    }
}
