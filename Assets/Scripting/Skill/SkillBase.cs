using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Skill Player", menuName = "Player/Skill")]
public class SkillBase : ScriptableObject
{
    public new string name;
    public int damage;
    public string description;
    public Image icon;
    public ParticleSystem effectSkill;
}
