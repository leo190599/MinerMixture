using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GerenciadorDeInput : MonoBehaviour,IInput
{
    [SerializeField]
    private float PontoMorto = 100;
    private Vector2 Direcao = new Vector2(0, 0);
    private Vector2 MouseInicial,MouseFinal = new Vector2(0, 0);
    private bool pressionado = false;

    public UnityEvent EventosButtonDown;

    public UnityEvent EventosButtonUp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pressionado = true;
            MouseInicial = Input.mousePosition;
            EventosButtonDown.Invoke();        
        }
        else if (Input.GetMouseButtonUp(0))
        {
            pressionado = false;
            Direcao = new Vector2(0, 0);
            EventosButtonUp.Invoke();
        }
        else
        {
            if (pressionado)
            {
                MouseFinal = Input.mousePosition;
                if ((MouseFinal-MouseInicial).magnitude>PontoMorto*Screen.width)
                {
                    Direcao = (MouseFinal - MouseInicial).normalized;
                }
                else
                {
                    Direcao = Vector2.zero;
                }
            }

        }
    }
    public Vector2 GetDirecao()
    {
        return Direcao;
    }

    public float GetPontoMorto()
    {
        return PontoMorto;
    }
}
