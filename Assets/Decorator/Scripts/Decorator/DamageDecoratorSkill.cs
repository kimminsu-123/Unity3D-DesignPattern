using UnityEngine;

public class DamageDecoratorSkill : DecoratorSkill
{
    private int _damage;
    
    public DamageDecoratorSkill(ISkill skill, int damage) : base(skill)
    {
        _damage = damage;
    }

    public override void Use()
    {
        base.Use();
        
        Debug.Log($"대미지를 주었습니다 : {_damage}");
    }
}