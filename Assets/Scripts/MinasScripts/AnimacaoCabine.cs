using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoCabine : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("aberto", false);
    }

    public void abrir()
    {
        anim.SetBool("aberto",true);
    }

    public void fechar()
    {
        anim.SetBool("aberto", false);
    }
}
