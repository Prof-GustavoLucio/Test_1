using UnityEngine;

public class InputEixos : MonoBehaviour
{
    // Variáveis que guardam 2 valores (X e Y)
    public Vector2 Movimentacao;
    public Vector2 MovimentacaoRaw;

    // Referencia dos objetos que vamos movimentar (Indicadores)
    public GameObject IndicadorMovimentação;
    public GameObject IndicadorMovimentaçãoRaw;



    // Roda todo frame do jogo
    void Update()
    {
        Update_Eixos();
    }


    // Função que recebe input de eixos e atualiza posições dos indicadores
    void Update_Eixos()
    {
        // Receber valores de eixos (Arredondado)
        Movimentacao.x = Input.GetAxis("Horizontal");
        Movimentacao.y = Input.GetAxis("Vertical");

        // Receber valores de eixos
        MovimentacaoRaw.x = Input.GetAxisRaw("Horizontal");
        MovimentacaoRaw.y = Input.GetAxisRaw("Vertical");


        // Atualizar indicador (Arredondado)
        IndicadorMovimentação.transform.localPosition = Movimentacao;
        // Atualizar indicador
        IndicadorMovimentaçãoRaw.transform.localPosition = MovimentacaoRaw;
    }
}
