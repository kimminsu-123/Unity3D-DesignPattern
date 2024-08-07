using System;
using UnityEngine;
using Random = System.Random;

public class SuccessDecoratorSkill : DecoratorSkill
{
    private int _successPercent;

    public SuccessDecoratorSkill(ISkill skill, int successPercent) : base(skill)
    {
        _successPercent = successPercent;
    }

    public override void Use()
    {
        try
        {
            Random r = new Random();
            int value = r.Next(1, 100);

            if (value <= _successPercent)
            {
                Debug.Log($"스킬 사용 성공 {value}");
                base.Use();
            }
            else
            {
                Debug.Log($"스킬 사용 실패 {value}");
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}