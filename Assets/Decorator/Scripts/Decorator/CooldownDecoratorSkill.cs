using System;
using UnityEngine;

namespace Decorator.Scripts.Decorator
{
    public class CooldownDecoratorSkill : DecoratorSkill
    {
        private int _cooldownTick;
        private TimeSpan _lastedUseTime; 
    
        public CooldownDecoratorSkill(ISkill skill, int cooldownTick) : base(skill)
        {
            _lastedUseTime = TimeSpan.Zero;
            _cooldownTick = cooldownTick;
        }

        public override void Use()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            double diff = now.TotalMilliseconds - _lastedUseTime.TotalMilliseconds;
        
            if (diff > _cooldownTick)
            {
                _lastedUseTime = now;
                base.Use();
            }
            else
            {
                Debug.Log($"아직 쿨타임 중입니다. {diff}");
            }
        }
    }
}