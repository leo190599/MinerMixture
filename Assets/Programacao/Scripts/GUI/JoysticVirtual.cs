using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoysticVirtual : MonoBehaviour
{
    [SerializeField]
    private RectTransform Joystic;
    [SerializeField]
    private RawImage ImagemJoystic;
    
    // Start is called before the first frame update
    public void SetarPosicaoJoystic()
    {
        //Debug.Log("a");
        Joystic.position = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
    }

    public void TornarJoysticVisivel()
    {
        ImagemJoystic.enabled = true;
    }

    public void TornarJoysticInvisivel()
    {
        ImagemJoystic.enabled = false;
    }
}
