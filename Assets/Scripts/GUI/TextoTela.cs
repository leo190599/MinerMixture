using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoTela : MonoBehaviour
{
    private TextMeshProUGUI Texto;
    // Start is called before the first frame update
    void Start()
    {
        Texto = GetComponent<TextMeshProUGUI>();
    }

    public void atualizarValor(int NovoValor)
    {
        Texto.text = NovoValor.ToString();
    }

}
