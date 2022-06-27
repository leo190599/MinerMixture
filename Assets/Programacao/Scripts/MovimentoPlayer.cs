using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject IInputObjeto;
 
    [SerializeField]
    private GameObject Cam;

    [SerializeField]
    private Vector3 OffsetCamera = new Vector3(0, 0, 0);

    [SerializeField]
    private float velocidade;

    private IInput GerenciadorDeInput;

    private Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        GerenciadorDeInput = IInputObjeto.GetComponent<IInput>();
       Rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector3(GerenciadorDeInput.GetDirecao().x*velocidade,Rb.velocity.y,GerenciadorDeInput.GetDirecao().y*velocidade);
        if (GerenciadorDeInput.GetDirecao().magnitude>0)
        {
            transform.eulerAngles = new Vector3(0, Mathf.Atan2(GerenciadorDeInput.GetDirecao().x, GerenciadorDeInput.GetDirecao().y) * Mathf.Rad2Deg, 0);
        }
        Cam.transform.position = transform.position + OffsetCamera;

    }
}
