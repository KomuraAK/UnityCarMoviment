using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodasCarro : MonoBehaviour
{
    public WheelCollider[] wColisor;
    public Transform[] rodas;
    private Vector3 posicao;
    private Quaternion rotacao;

    void Update()
    {
        Rodas();
    }

    void Rodas()
    {
        for (int i = 0; i < wColisor.Length; i++){
            wColisor[i].GetWorldPose(out posicao, out rotacao);
            rodas[i].position = posicao;
            rodas[i].rotation = rotacao;
        }
    }
}
