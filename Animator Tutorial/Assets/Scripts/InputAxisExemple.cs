using UnityEngine;

public class InputAxisExemple : MonoBehaviour
{
    public float Movimento_X;
    public float Movimento_Y;

    public float ForcaMovimento;

    public Vector2 VetorMovimento;

    public Transform Referencia;

    // Update is called once per frame
    void Update()
    {
        Update_Eixos();
    }


    void Update_Eixos()
    {
        // Deve ser declarada junto das outras variaveis
        //public Vector2 nomeVetor;

        // Receber os valores dos eixos
        Movimento_X = Input.GetAxis("Horizontal");
        Movimento_Y = Input.GetAxis("Vertical");

        VetorMovimento.x = Movimento_X * ForcaMovimento;
        VetorMovimento.y = Movimento_Y * ForcaMovimento;

        Referencia.position = VetorMovimento;
    }
}
