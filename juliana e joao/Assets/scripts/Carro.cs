using UnityEngine;

public class Carro : MonoBehaviour
{
    public float VelocidadeM = 100f;
    public ConstantForce2D force;
    
    public bool capotou = false;
    
    public enum  Direcao
    {
        Frente, Traz
    }
    
    public Direcao direcao = Direcao.Frente;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (capotou == false)
        {
            if (Input.GetKey(KeyCode.D))
            {
                direcao = Direcao.Frente;
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                direcao = Direcao.Traz;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (direcao == Direcao.Frente)
                {
                    force.force = Vector2.right*VelocidadeM;
                }
                else if (direcao == Direcao.Traz)
                {
                    force.force = Vector2.left*VelocidadeM;
                }
            }
            else
            {
                force.force = Vector2.zero;
            }
        }

        else
        {
            force.force = Vector2.zero;
        }
    }
    
}
