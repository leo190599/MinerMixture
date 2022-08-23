using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorDeMinerios : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject recursoFisico;
    [SerializeField]
    private float tempoParaInstanciarRecursos=1;
    [SerializeField]
    private Transform localDeInstancia;

    public void criarRecursoColeta()
    {
        StartCoroutine("corrotinaInstanciaRecursoFisico");
    }

    IEnumerator corrotinaInstanciaRecursoFisico()
    {
        yield return new WaitForSeconds(tempoParaInstanciarRecursos);
        GameObject g;
        g=Instantiate(recursoFisico, localDeInstancia.position, localDeInstancia.rotation);
        g.GetComponent<RecursoFisico>().setPai(this);
    }
}
