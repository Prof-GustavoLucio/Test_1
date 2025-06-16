using UnityEngine;

public class InputEixos : MonoBehaviour
{
    // Vari�veis que guardam 2 valores (X e Y)
    public Vector2 Movimentacao;
    public Vector2 MovimentacaoRaw;

    // Referencia dos objetos que vamos movimentar (Indicadores)
    public GameObject IndicadorMovimenta��o;
    public GameObject IndicadorMovimenta��oRaw;



    // Roda todo frame do jogo
    void Update()
    {
        Update_Eixos();
    }


    // Fun��o que recebe input de eixos e atualiza posi��es dos indicadores
    void Update_Eixos()
    {
        // Receber valores de eixos (Arredondado)
        Movimentacao.x = Input.GetAxis("Horizontal");
        Movimentacao.y = Input.GetAxis("Vertical");

        // Receber valores de eixos
        MovimentacaoRaw.x = Input.GetAxisRaw("Horizontal");
        MovimentacaoRaw.y = Input.GetAxisRaw("Vertical");


        // Atualizar indicador (Arredondado)
        IndicadorMovimenta��o.transform.localPosition = Movimentacao;
        // Atualizar indicador
        IndicadorMovimenta��oRaw.transform.localPosition = MovimentacaoRaw;
    }
}
