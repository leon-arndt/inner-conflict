using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : GameCharacter
{
    public static PlayerCombat Instance;

    public GameObject bulletPrefab, meleePrefab;

    public float m_health;
    private float m_maxHealth;

    private void Start()
    {
        Instance = this;
        m_maxHealth = m_health;
    }

    public void CreateBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
        bullet.GetComponent<Hitbox>().owner = this;
    }

    void CreateMelee()
    {
        
    }

    public void TakeDamage(float damageToTake)
    {
        m_health -= damageToTake;

        UiController.Instance.UpdatePlayerHealth(m_health / m_maxHealth);

        if (m_health <= 0)
        {
            CharacterController2D.Instance.Respawn();
        }
    }

    public void RecoverFullHealth()
    {
        m_health = m_maxHealth;
        UiController.Instance.UpdatePlayerHealth(m_health / m_maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Hitbox>())
        {
            if (collision.GetComponent<Hitbox>().owner == this)
                return;

            TakeDamage(collision.GetComponent<Hitbox>().attackStrength);
        }
    }
}
