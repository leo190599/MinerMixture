using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GerenciadorRecursosTela : MonoBehaviour
{
    [SerializeField]
    private Recurso recursoASerVisto;
    [SerializeField]
    private Image ImagemRecurso;
    [SerializeField]
    private TextMeshProUGUI TextoRecurso;
    // Start is called before the first frame update
    void Start()
    {
        ImagemRecurso.sprite = recursoASerVisto.getImagem;
        atualizarTexto();
    }

    public void atualizarTexto()
    {
        TextoRecurso.text = recursoASerVisto.getQuantidade.ToString();
    }
}
