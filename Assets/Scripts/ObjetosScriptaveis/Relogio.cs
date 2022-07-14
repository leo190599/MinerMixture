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
        if (eventosPassarTempo != null)
        {
            eventosPassarTempo.Invoke();
        }
    }

    public void adicionarTempo(Object chamador,float quantidadeDeTempo)
    {
        tempo += tempo;
        if (eventosPassarTempo!=null)
        {
            eventosPassarTempo.Invoke();
        }
    }

    public void passarTempo(Object chamador, float tempoDecorrido)
    {
        tempo -= tempoDecorrido;
        tempo=Mathf.Clamp(tempo,0,Mathf.Infinity);
        if (eventosPassarTempo != null)
        {
            eventosPassarTempo.Invoke();
        }
        if(tempo==0 && eventosTerminaTempo!=null)
        {
            eventosTerminaTempo.Invoke();
        }
    }


    public float getTempoSegundos => tempo%60;
    public float getTempoMinutos => Mathf.Floor(tempo / 60);
}
