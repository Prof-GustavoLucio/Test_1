using UnityEngine;

public class TriggerAnimations : MonoBehaviour
{
    public Animator PlayerAnimator;
    public KeyCode TeclaDesejada1;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(TeclaDesejada1))
        {
            Debug.Log("Tecla Pressionada");
            PlayerAnimator.SetBool("IsMoving", true);
        }

        if (Input.GetKeyUp(TeclaDesejada1))
        {
            Debug.Log("Tecla Pressionada");
            PlayerAnimator.SetBool("IsMoving", false);
        }
    }
}
