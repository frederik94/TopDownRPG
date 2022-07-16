using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalentManager : MonoBehaviour
{
    public Color defaultColor = Color.black;
    public Color activatedColor = Color.red;
    public List<Talent> talents;

    private void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("TalentAbility");
        foreach (GameObject talentAbility in objects){
            talents.Add(talentAbility.GetComponent<Talent>());
        }
    }
    public void TestMethod(Talent talent)
    {
        bool Obtainable = true;
        foreach(int requiredId in talent.requiredIds)
        {
            if (CheckIfValid(requiredId) == false)
            {
                Obtainable = false;
            }
        }

        if (Obtainable == true)
        {
            talent.activated = talent.activated == true ? false : true;

            ApplyTalentEffect();

            foreach (Transform transform in talent.affectedLines)
            {
                EditUI(transform, talent.activated);
            }
        }
    }

    public void ApplyTalentEffect()
    {

    }

    public bool CheckIfValid(int id)
    {
        Talent talent = talents.Find(item => item.Id == id);
        if (talent.activated == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void EditUI(Transform transform, bool isActive)
    {
        SpriteRenderer renderer = transform.GetComponent<SpriteRenderer>();

        if (isActive == true)
        {
            renderer.color = activatedColor;
        }
        else
        {
            renderer.color = defaultColor;
        }
    }
}
