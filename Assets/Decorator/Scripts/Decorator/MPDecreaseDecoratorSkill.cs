using UnityEngine;

public class MPDecreaseDecoratorSkill : DecoratorSkill
{
    private int _useMp;
    
    public MPDecreaseDecoratorSkill(ISkill skill, int mp) : base(skill)
    {
        _useMp = mp;
    }

    public override void Use()
    {
        base.Use();
        Debug.Log($"MP 사용 : {_useMp}");
    }
}