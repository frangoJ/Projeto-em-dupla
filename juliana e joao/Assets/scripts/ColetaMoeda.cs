using UnityEngine;

public class ColetaMoeda : MonoBehaviour
{
    
    
    public static ColetaMoeda instance;

    public int moedas = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AdicionarMoeda(int valor)
    {
        moedas += valor;
        Debug.Log("Moedas: " + moedas);
    }
}