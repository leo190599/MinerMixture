using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaylistAudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource tocador;
    [SerializeField]
    private AudioClip[] musicas;
    [SerializeField]
    private int ponteiroMusica;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        tocador.clip = musicas[ponteiroMusica];
        tocador.Play();
        ponteiroMusica++;
        if (ponteiroMusica >= musicas.Length)
        {
            ponteiroMusica = 0;
        }
        yield return new WaitForSeconds(tocador.clip.length);
        StartCoroutine(Start());
    }

}