using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeRelogio : MonoBehaviour
{
    [SerializeField]
    private Relogio r;
    [SerializeField]
    private float intervalosEmSegundos = 60;
    [System.Serializable]
    private class recursosASeremCobrados
    {
        [SerializeField]
        private Recurso r;
        [SerializeField]
        private float quantidade=10;

        public Recurso getRecurso => r;
        public float getQuantidade => quantidade;
    }

    [SerializeField]
    private recursosASeremCobrados[] rASeremCobrados;

    private void Start()
    {
        r.setTempo(this, intervalosEmSegundos);
        StartCoroutine("PassarRelogio");
    }

    private void OnEnable()
    {
        r.eventosTerminaTempo += ressetaTempo;
        r.eventosTerminaTempo += cobrarRecursos;
    }

    private void OnDisable()
    {
        r.eventosTerminaTempo -= ressetaTempo;
        r.eventosTerminaTempo -= cobrarRecursos;
    }

    IEnumerator PassarRelogio()
    {
        yield return new WaitForSeconds(1);
        r.passarTempo(this,1);
        StartCoroutine("PassarRelogio");
    }

    public void cobrarRecursos()
    {
        foreach (recursosASeremCobrados r in rASeremCobrados)
        {
            r.getRecurso.cobrar(this, r.getQuantidade);
        }
    }

    public void ressetaTempo()
    {
        r.setTempo(this,intervalosEmSegundos);
    }
}
