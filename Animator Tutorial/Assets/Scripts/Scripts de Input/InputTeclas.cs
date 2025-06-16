using UnityEngine;

public class InputTeclas : MonoBehaviour
{
    // Referencia da tecla desejada
    public KeyCode TeclaSelecionada;

    // Sprite que será modificada
    public SpriteRenderer SpriteReferencia;



    // Roda todo frame do jogo
    void Update()
    {
        // Checar se a tecla definida foi Apertada
        if (Input.GetKeyDown(TeclaSelecionada))
        {
            SpriteReferencia.color = Color.green;
        }

        // Checar se a tecla definida foi Solta
        if (Input.GetKeyUp(TeclaSelecionada))
        {
            SpriteReferencia.color = Color.white;
        }
    }
}
