using UnityEngine;
using TMPro;

public class UI_Moedas : MonoBehaviour
{
    public TextMeshProUGUI texto;

    void Update()
    {
        if (ColetaMoeda.instance != null && texto != null)
        {
            texto.text = "Moedas: " + ColetaMoeda.instance.moedas;
        }
    }
}