using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillController : BaseCharacter
{
    public static SkillController gm_Instance;
    [SerializeField] private SkillBase[] skills;
    private SkillBase skillPlayer;

    #region Singleton
    private void Awake()
    {
        CheckInstance();
    }

    void CheckInstance() {
        if(gm_Instance != null){
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
            gm_Instance = this;
        }
    }
    #endregion

    public void SelectSkill(int select){
        skillPlayer = skills[select];
    } 

    public void UseSkill(RaycastHit outhit) {
        //we need some effect like ui or particle system
        //turn around the ghost look at you

        var ghost = outhit.collider.GetComponent<GhostStat>();
        if(ghost.weakness == skillPlayer.name)
            Damage(skillPlayer.damage, ghost.Health);
        else if(ghost.weakness != skillPlayer.name)
            Damage(skillPlayer.damage * Random.Range(0.3f, 2f), ghost.Health);
    }
}
