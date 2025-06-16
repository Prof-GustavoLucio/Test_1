using UnityEngine;

public class MouseComands : MonoBehaviour
{
    // Cor Padrão (sem interação)
    public Color Cor1;
    // Cor Para quando o mouse estiver em cima do sprite
    public Color Cor2;
    // Cor Para quando clicar no sprite
    public Color Cor3;

    // Sprite que será modificada
    [SerializeField] SpriteRenderer spriteReferencia;


    // Booleana para definir se o mouse esta sobre o colisor do objeto
    bool estaSobreColisor;
    // Booleana para definir se o mouse esta clicando no objeto
    bool estaClicando;



    // Roda no início do jogo
    private void Start()
    {
        spriteReferencia = GetComponent<SpriteRenderer>();
    }


    // Roda ao Detectar mouse entrando no colisor do objeto
    private void OnMouseEnter()
    {
        estaSobreColisor = true;
        
        if (!estaClicando)
        {
            spriteReferencia.color = Cor2;
        }
    }

    // Roda ao Detectar mouse saindo do colisor do objeto
    private void OnMouseExit()
    {
        estaSobreColisor = false;

        if (!estaClicando)
        {
            spriteReferencia.color = Cor1;
        }
    }

    // Roda ao Detectar clique do mouse sobre colisor do objeto
    private void OnMouseDown()
    {
        estaClicando = true;

        spriteReferencia.color = Cor3;
    }

    // Roda ao Detectar que clique do mouse foi solto
    private void OnMouseUp()
    {
        estaClicando = false;
        
        if (estaSobreColisor)
        {
            spriteReferencia.color = Cor2;
        }
        else
        {
            spriteReferencia.color = Cor1;
        }
    }
}
