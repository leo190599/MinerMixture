using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorSom : MonoBehaviour
{
    public void instanciarEmissorDeSom(GameObject emissor)
    {
        GameObject a = Instantiate(emissor, transform.position, Quaternion.identity);
        AudioSource aS = a.GetComponent<AudioSource>();
        if (aS == null)
        {
            Destroy(a);
            Debug.LogError("Não há um emissor de audio nesse objeto");
        }
        else
        {
            if (aS.clip != null)
            {
                aS.Play();
                Destroy(a, aS.clip.length);
            }
            else
            {
                Debug.LogError("Não há um clip no emissor de audio do objeto" + a);
                Destroy(a);
            }
        }
    }
}
