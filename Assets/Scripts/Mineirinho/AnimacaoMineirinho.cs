using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoMineirinho : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private Rigidbody rb;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude>0.5f)
        {
            anim.SetBool("Correndo",true);
        }
        else
        {
            anim.SetBool("Correndo",false);
        }
    }
}
