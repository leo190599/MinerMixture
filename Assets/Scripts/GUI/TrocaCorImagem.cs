using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocaCorImagem : MonoBehaviour
{
    [SerializeField]
    private Color[] cores;
    [SerializeField]
    private Image imagem;
    
    public void trocarCor(int indexDaCor)
    {
        if(indexDaCor>=cores.Length)
        {
            Debug.LogError("Não há esse index");
            return;
        }
        imagem.color = cores[indexDaCor];
    }
}
