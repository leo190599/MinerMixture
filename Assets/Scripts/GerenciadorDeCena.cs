using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeCena : MonoBehaviour
{
    [SerializeField]
    private GerenciadorEstadoDeJogo gerenciador;
    void Start()
    {
        gerenciador.despausar(this);
    }
    public void trocarEstado()
    {
        gerenciador.trocarEstado(this);
    }
}
