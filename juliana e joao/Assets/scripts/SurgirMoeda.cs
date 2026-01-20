using UnityEngine;

public class SurgirMoeda : MonoBehaviour
{
    //deu erradokkkkkkkkkkkkkl
    [Header("Referências")]
    public Transform carro;
    public Camera cam;
    public GameObject moedaPrefab;
    public LayerMask layerChao;

    [Header("Configurações")]
    public float distanciaFrente = 5f;
    public float distanciaEntreMoedas = 1.5f;
    public int moedasPorSpawn = 5;
    public float alturaRaycast = 15f;
    public float offsetY = 0.5f;

    private float ultimoXSpawn;

    void Start()
    {
        ultimoXSpawn = carro.position.x;
    }

    void Update()
    {
        float limiteDireitoCamera =
            cam.transform.position.x + cam.orthographicSize * cam.aspect;

        if (limiteDireitoCamera > ultimoXSpawn + distanciaFrente)
        {
            SpawnLinhaDeMoedas(limiteDireitoCamera + distanciaFrente);
            ultimoXSpawn = limiteDireitoCamera + (moedasPorSpawn * distanciaEntreMoedas);

        }
    }

    void SpawnLinhaDeMoedas(float xInicial)
    {
        for (int i = 0; i < moedasPorSpawn; i++)
        {
            float x = xInicial + i * distanciaEntreMoedas;
            Vector2 origem = new Vector2(x, alturaRaycast);

            RaycastHit2D hit = Physics2D.Raycast(origem, Vector2.down, 50f, layerChao);

            if (hit.collider != null)
            {
                Vector2 pos = hit.point;
                pos.y += offsetY;

                Instantiate(moedaPrefab, pos, Quaternion.identity);
            }
        }
    }
}