using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public float ingameLevel;
    public float currentExp;
    public float maxExp;
    public float expMultiplier = 1.2f;
    void Start()
    {
        ingameLevel = 1f;
        currentExp = 0f;
        maxExp = 100f;
    }

    public void AddExp(float expValue)
    {
        float totalExp = currentExp + expValue;
        if (totalExp >= maxExp)
        {
            currentExp = totalExp - maxExp;
            ingameLevel += 1;
            maxExp *= expMultiplier;
        }
        else
        {
            currentExp += expValue;
        }
    }
}
