using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName ="NovoTrocadorDeCenas",menuName ="TrocadorDeCenas")]
public class trocadorDeCenas : ScriptableObject
{
    // Start is called before the first frame update
    public void trocarCena(string nomeDaCenaASerCarregada)
    {
        SceneManager.LoadScene(nomeDaCenaASerCarregada);
    }
   
}
