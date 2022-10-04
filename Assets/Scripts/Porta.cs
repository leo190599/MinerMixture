using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Porta : MonoBehaviour
{
    [System.Serializable]
    public class RecursosNecessarios
    {
        [SerializeField]
        private Recurso recursoAServisto;
        [SerializeField]
        private float quantidadeNecessaria;

        public bool possuiAQuantidadeNecessaria => recursoAServisto.getQuantidade >= quantidadeNecessaria;
    }
    [SerializeField]
    private RecursosNecessarios[] recursosNecessarios;
    [SerializeField]
    private UnityEvent eventosAbertura;
    [SerializeField]
    private UnityEvent eventosFalhaAbertura;

    // Start is called before the first frame update
    public void tentarAbertura()
    {
        if(recursosNecessarios.Length>0)
        {
            foreach(RecursosNecessarios r in recursosNecessarios)
            {
                if(!r.possuiAQuantidadeNecessaria)
                {
                    if(eventosFalhaAbertura!=null)
                    {
                        eventosFalhaAbertura.Invoke();
                    }
                    return;
                }
            }
            Abrir();
        }
        else
        {
            Abrir();
        }
    }

    // Update is called once per frame
    public void Abrir()
    {
        if(eventosAbertura!=null)
        {
            eventosAbertura.Invoke();
        }
    }
}
