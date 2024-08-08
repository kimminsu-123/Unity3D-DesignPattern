using UnityEngine;

namespace Decorator.Scripts.Decorator
{
    public class BaseSkill : ISkill
    {
        public void Use()
        {
            // 기본적으로 서버에 통신을 보내는 로직이 있으면 좋을 듯?
            Debug.Log("스킬을 사용합니다.");
        }
    }
}