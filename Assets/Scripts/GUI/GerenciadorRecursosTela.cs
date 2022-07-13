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
    [SerializeField]
    private TextMeshProUGUI textoIncremento;
    // Start is called before the first frame update
    void Awake()
    {
        ImagemRecurso.sprite = recursoASerVisto.getImagem;
    }

    private void OnEnable()
    {
        recursoASerVisto.eventosASeremChamados += atualizarTexto;
        recursoASerVisto.eventosIncremento += atualizarIncremento;
    }
    private void OnDisable()
    {
        recursoASerVisto.eventosASeremChamados -= atualizarTexto;
        recursoASerVisto.eventosIncremento -= atualizarIncremento;
    }

    public void atualizarTexto()
    {
        TextoRecurso.text = recursoASerVisto.getQuantidade.ToString();
    }
    public void atualizarIncremento()
    {
        textoIncremento.text = (recursoASerVisto.getIncremento/recursoASerVisto.getTempoDeIncremento).ToString("0.00")+" /seg";
    }
}