using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerMina : MonoBehaviour
{
    [SerializeField]
    private UnityEvent EventosEntrada, EventosSaida;
    [SerializeField]
    private string TagAInteragir="Player";
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag==TagAInteragir)
        {
            EventosEntrada.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == TagAInteragir)
        {
            EventosSaida.Invoke();
        }
    }
}
