using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoMisturador : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void comecarMistura()
    {
        anim.SetBool("misturando",true);
    }

    public void pararMistura()
    {
        anim.SetBool("misturando", false);
    }
}
