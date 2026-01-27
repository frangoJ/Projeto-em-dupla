using UnityEngine;

public class Moeda : MonoBehaviour
{
    [Header("Giro")]
    public float velocidade = 5f;
    public float escalaMinima = 0.2f;

    [Header("Coleta")]
    public int valor = 1;

    private Vector3 escalaInicial;
    private AudioSource audioSource;
    
    private bool coletada = false;

    void Start()
    {
        escalaInicial = transform.localScale;
        audioSource = GetComponent<AudioSource>();
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
        if (coletada) return;

        if (other.CompareTag("Player"))
        {
            coletada = true;

            ColetaMoeda.instance.AdicionarMoeda(valor);

            audioSource.Play();
            
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;

            Destroy(gameObject, audioSource.clip.length);
        }
    }
}