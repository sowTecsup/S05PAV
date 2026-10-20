using UnityEngine;

public class Door : MonoBehaviour,IDamageable,IInteractable
{
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void TakeDamage(int damage)
    {
        print("Desaparece la puerta, instanciamos particulas de destruccion y sonido de romper");
    }

    public void Interact(GameObject user)
    {
        print("El usuario" + user.name + "Interactuo conmigo");
    }
}
