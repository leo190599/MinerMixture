using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoPorta : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void AbrirPorta()
    {
        anim.SetBool("aberta",true);
    }
}
