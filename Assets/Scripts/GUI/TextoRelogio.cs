using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoRelogio : MonoBehaviour
{
    [SerializeField]
    private Relogio r;
    private TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        atualizarTexto();
        r.eventosPassarTempo += atualizarTexto;
    }
    
    public void atualizarTexto()
    {
        texto.text = r.getTempoMinutos.ToString("00") + ":" + r.getTempoSegundos.ToString("00");
    }
}
