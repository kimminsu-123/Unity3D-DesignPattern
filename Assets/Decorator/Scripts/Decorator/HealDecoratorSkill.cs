using UnityEngine;

namespace Decorator.Scripts.Decorator
{
    public class HealDecoratorSkill : DecoratorSkill
    {
        private int _healAmount;
    
        public HealDecoratorSkill(ISkill skill, int heal) : base(skill)
        {
            _healAmount = heal;
        }

        public override void Use()
        {
            base.Use();
            Debug.Log($"체력이 회복 되었습니다 : {_healAmount}");
        }
    }
}