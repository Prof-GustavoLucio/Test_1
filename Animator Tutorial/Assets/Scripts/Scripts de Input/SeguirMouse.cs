using UnityEngine;

public class SeguirMouse : MonoBehaviour
{
    // Referencia do objeto que vamos movimentar (Círculo que segue o mouse)
    public Transform ObjetoReferencia;

    // Variáveis que guardam 2 valores (X e Y)
    Vector2 posMouse;



    // Roda todo frame do jogo
    private void Update()
    {
        // Receber posição do mouse na tela
        posMouse = Input.mousePosition;
        // Converter posição da tela para posição do mundo
        posMouse = Camera.main.ScreenToWorldPoint(posMouse);


        // Atualizar posição do objeto referencia
        ObjetoReferencia.position = posMouse;
    }
}
