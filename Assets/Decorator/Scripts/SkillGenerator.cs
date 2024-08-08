using System.Collections.Generic;
using Decorator.Scripts.Decorator;
using UnityEngine;

namespace Decorator.Scripts
{
    public class SkillGenerator : MonoBehaviour
    {
        public SkillLoader loader;

        private Dictionary<int, ISkill> _skills;

        public ISkill GetSkill(int id) => _skills[id];
    
        private void Awake()
        {
            _skills = new Dictionary<int, ISkill>();
        }

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            foreach (SkillData data in loader.data.skills)
            {
                ISkill skill = Generate(data);
            
                _skills.Add(data.id, skill);
            }
        }

        private ISkill Generate(SkillData data)
        {
            ISkill newSkill = new BaseSkill();
        
            if (0 < data.damage)
            {
                newSkill = new DamageDecoratorSkill(newSkill, data.damage);
            }

            if (0 < data.heal)
            {
                newSkill = new HealDecoratorSkill(newSkill, data.heal);
            }

            if (0 < data.mp)
            {
                newSkill = new MPDecreaseDecoratorSkill(newSkill, data.mp);
            }
        
            if (data.success is > 0 and < 100)
            {
                newSkill = new SuccessDecoratorSkill(newSkill, data.success);
            }
        
            if (0 < data.readyTime)
            {
                newSkill = new ReadyDecoratorSkill(newSkill, data.readyTime);
            }
        
            if (0 < data.cooldown)
            {
                newSkill = new CooldownDecoratorSkill(newSkill, data.cooldown);
            }

            return newSkill;
        }
    }
}