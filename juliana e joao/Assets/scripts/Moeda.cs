using UnityEngine;

public class Moeda : MonoBehaviour
{
    [Header("Giro da moeda")]
    public float velocidade = 5f;
    public float escalaMinima = 0.2f;

    [Header("Coleta")]
    public int valor = 1;

    private Vector3 escalaInicial;

    void Start()
    {
        escalaInicial = transform.localScale;
    }

    void Update()
    {
        float x = Mathf.Abs(Mathf.Sin(Time.time * velocidade));
        x = Mathf.Lerp(escalaMinima, 1f, x);

        transform.localScale = new Vector3(
            escalaInicial.x * x,
            escalaInicial.y,
            escalaInicial.z
        );
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ColetaMoeda.instance.AdicionarMoeda(valor);
            Destroy(gameObject);
        }
    }
}