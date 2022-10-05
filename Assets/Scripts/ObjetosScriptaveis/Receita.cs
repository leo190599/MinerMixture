using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName ="NovaReceita",menuName ="receita")]
public class Receita : ScriptableObject
{
    [System.Serializable]
    private class minerioQuantidade
    {
        [SerializeField]
        private Recurso recurso;
        [SerializeField]
        private int quantidade;

        public Recurso getRecurso => recurso;
        public int getQuantidade => quantidade;
    }
    [SerializeField]
    private minerioQuantidade[] entradas;
    [SerializeField]
    private minerioQuantidade[] saidas;
    [SerializeField]
    private float tempoDeMistura;
    public UnityAction EventosMistura;
    public UnityAction EventosFalhaMistura;
    public void misturar(Object chamador)
    {
        foreach(minerioQuantidade m in entradas)
        {
            if(!(m.getRecurso.getQuantidade >= m.getQuantidade))
            {
                if (EventosFalhaMistura!=null)
                {       
                    EventosFalhaMistura.Invoke();
                }
                return;
            }
        }
        foreach(minerioQuantidade m in entradas)
        {
            m.getRecurso.comprar(this, m.getQuantidade);
        }
        foreach(minerioQuantidade m in saidas)
        {
            m.getRecurso.somarQuantidade(this, m.getQuantidade);
        }
        if (EventosMistura != null)
        {
            EventosMistura.Invoke();
        }
    }

    public float getTempoDeMistura => tempoDeMistura;
    // Start is called before the first frame update

}