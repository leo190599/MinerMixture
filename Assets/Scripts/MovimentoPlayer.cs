using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    [SerializeField]
    private GerenciadorEstadoDeJogo gerenciadorEstado;
    [SerializeField]
    private GameObject IInputObjeto;
 
    [SerializeField]
    private GameObject Cam;

    [SerializeField]
    private Vector3 OffsetCamera = new Vector3(0, 0, 0);

    [SerializeField]
    private float velocidade;

    [SerializeField]
    private GerenciadorDeInput OGerenciadorDeInput;

    private Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
       Rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector3(OGerenciadorDeInput.GetDirecao().x*velocidade,Rb.velocity.y,OGerenciadorDeInput.GetDirecao().y*velocidade);
        if (OGerenciadorDeInput.GetDirecao().magnitude>0 && gerenciadorEstado.getEstado==GerenciadorEstadoDeJogo.jogando)
        {
            transform.eulerAngles = new Vector3(0, Mathf.Atan2(OGerenciadorDeInput.GetDirecao().x, OGerenciadorDeInput.GetDirecao().y) * Mathf.Rad2Deg, 0);
        }
        Cam.transform.position = transform.position + OffsetCamera;

    }
}
