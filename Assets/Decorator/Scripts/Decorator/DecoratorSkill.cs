using UnityEngine;

public class DecoratorSkill : ISkill
{
    private ISkill _skill;

    protected DecoratorSkill(ISkill skill)
    {
        _skill = skill;
    }
    
    public virtual void Use()
    {
        _skill?.Use();
    }
}