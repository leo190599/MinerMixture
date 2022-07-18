using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaMenus : MonoBehaviour
{
    [SerializeField]
    private GameObject menuAtivo;
    [SerializeField]
    private GameObject[] menus;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject g in menus)
        {
            if(menuAtivo!=g)
            {
                g.SetActive(false);
            }
            else
            {
                g.SetActive(true);
            }
        }
    }

    public void troca(int indexMenuAAtivar)
    {
        menuAtivo.SetActive(false);
        menuAtivo = menus[indexMenuAAtivar];
        menuAtivo.SetActive(true);
    }
}
