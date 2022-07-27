using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeCena : MonoBehaviour
{
    [SerializeField]
    private GerenciadorEstadoDeJogo gerenciador;
    void Start()
    {
        gerenciador.trocarEstado(GerenciadorEstadoDeJogo.jogando);
    }
}
