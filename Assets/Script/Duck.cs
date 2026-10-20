using UnityEngine;

public class Duck : MonoBehaviour,IDamageable
{
   
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        print("Cuack");
    }

}
