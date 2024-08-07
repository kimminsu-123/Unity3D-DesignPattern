using System;

[Serializable]
public class SkillData
{
    public int id;
    public int mp;
    public int readyTime;
    public int success;
    public int heal;
    public int damage;
    public int cooldown;
}

[Serializable]
public class SkillsData
{
    public SkillData[] skills;
}
