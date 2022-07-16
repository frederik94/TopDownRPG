using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Image bar;
    public GameObject entity;
    public PlayerController playerScript;

    void Start()
    {
        bar = gameObject.GetComponent<Image>();
        playerScript = entity.GetComponent<PlayerController>();
    }

    void Update()
    {
        float currentMana = playerScript.baseStats.currentMana;
        float maxMana = playerScript.baseStats.maxMana;
        bar.fillAmount = currentMana / maxMana;
    }
}
