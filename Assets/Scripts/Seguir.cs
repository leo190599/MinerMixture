using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    [SerializeField]
    private Transform coordenadaASerSeguida;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position-coordenadaASerSeguida.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = coordenadaASerSeguida.position + offset;
    }
}
