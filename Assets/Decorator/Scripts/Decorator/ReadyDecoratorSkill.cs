using System.Threading.Tasks;
using UnityEngine;

namespace Decorator.Scripts.Decorator
{
    public class ReadyDecoratorSkill : DecoratorSkill
    {
        private int _readyTick;
        private bool _isReady;
    
        public ReadyDecoratorSkill(ISkill skill, int readyTick) : base(skill)
        {
            _isReady = false;
            _readyTick = readyTick;
        }

        public override void Use()
        {
            if (_isReady)
            {
                Debug.Log("스킬이 준비중입니다.");
                return;
            }

            _isReady = true;
        
            Debug.Log("스킬 준비중..");

            Task.Delay(_readyTick).ContinueWith((t) =>
            {
                _isReady = false;
                Debug.Log("스킬 준비 완료");
            
                base.Use();
            });
        }
    }
}