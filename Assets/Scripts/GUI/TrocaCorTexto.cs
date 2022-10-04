using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrocaCorTexto : MonoBehaviour
{
    [SerializeField]
    private Color[] cores;
    private TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }

    public void mudarCor(int indexCor)
    {
        if(indexCor>=cores.Length)
        {
            Debug.LogError("Não há esse index");
            return;
        }
        texto.color = cores[indexCor];
    }
}
