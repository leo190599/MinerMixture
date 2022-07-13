using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="novoRelogio",menuName ="Relogio")]
public class Relogio : ScriptableObject
{
    [SerializeField]
    private float tempo = 0;
    public UnityAction eventosPassarTempo;
    public UnityAction eventosTerminaTempo;
    
    public void setTempo(Object chamador,float novoTempo)
    {
        tempo = novoTempo;
        eventosPassarTempo.Invoke();
    }

    public void adicionarTempo(Object chamador,float quantidadeDeTempo)
    {
        tempo += tempo;
        eventosPassarTempo.Invoke();
    }

    public void passarTempo(Object chamador, float tempoDecorrido)
    {
        tempo -= tempoDecorrido;
        tempo=Mathf.Clamp(tempo,0,Mathf.Infinity);
        eventosPassarTempo.Invoke();
        if(tempo==0)
        {
            eventosTerminaTempo.Invoke();
        }
    }


    public float getTempo => tempo;
}
