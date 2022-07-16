using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    // Start is called before the first frame update
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
        float currentHp = playerScript.baseStats.currentHealth;
        float maxHp = playerScript.baseStats.maxHealth;
        bar.fillAmount = currentHp / maxHp;
    }
}
