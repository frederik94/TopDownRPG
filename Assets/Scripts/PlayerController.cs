using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : EntityBase
{
    Rigidbody2D rb;
    public Vector2 movementInput;
    public float dashSpeed = 100f;
    [SerializeField] public KeyCode keybinding;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        baseStats = gameObject.GetComponent<BaseStats>();
        playerStats = gameObject.GetComponent<PlayerProgress>();
        baseStats.currentHealth = baseStats.maxHealth;
        baseStats.currentMana = baseStats.maxMana;
        movementSpeed = 200f;
        float playerLevel = playerStats.ingameLevel;
        baseStats.strength = 1 + playerLevel;
        baseStats.intellect = 1 + playerLevel;
        baseStats.haste = 1 + playerLevel;
        baseStats.stamina = 1 + playerLevel;
        baseStats.defense = 1 + playerLevel;
    }

    void Update()
    {
        movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(keybinding))
        {
            rb.velocity = movementInput * dashSpeed * Time.deltaTime;
        }
        else
        {
            rb.velocity = movementInput * movementSpeed * Time.deltaTime;
        }
    }
}
