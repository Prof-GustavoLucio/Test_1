using UnityEngine;

public class SeguirMouse : MonoBehaviour
{
    // Referencia do objeto que vamos movimentar (C�rculo que segue o mouse)
    public Transform ObjetoReferencia;

    // Vari�veis que guardam 2 valores (X e Y)
    Vector2 posMouse;



    // Roda todo frame do jogo
    private void Update()
    {
        // Receber posi��o do mouse na tela
        posMouse = Input.mousePosition;
        // Converter posi��o da tela para posi��o do mundo
        posMouse = Camera.main.ScreenToWorldPoint(posMouse);


        // Atualizar posi��o do objeto referencia
        ObjetoReferencia.position = posMouse;
    }
}
