using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Carro carro;
    
    private float contador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (contador > 10)
        {
            contador = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }

        if (carro.capotou == true)
        {
            contador += Time.deltaTime;
        }

        else
        {
            contador = 0;
        }
    }
}
