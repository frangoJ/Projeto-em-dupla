using System;
using UnityEngine;

public class LihaChegada : MonoBehaviour
{

    public GameObject mensagem;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            mensagem.SetActive(true);
        }
    }
}
