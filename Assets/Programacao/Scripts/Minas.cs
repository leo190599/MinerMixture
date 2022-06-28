using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minas : MonoBehaviour
{
    [SerializeField]
    private Material MaterialDesativado, MaterialAtivado;
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
    }

    public void Desativar()
    {
        renderizador.material = MaterialDesativado;
    }
}
