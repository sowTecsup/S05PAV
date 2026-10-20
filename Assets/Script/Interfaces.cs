using UnityEngine;

public interface IDamageable
{
    public void TakeDamage(int damage);
}

public interface IInteractable
{
    public void Interact(GameObject user);
}

public interface IUseSkill
{
    public void UseSkill();
}