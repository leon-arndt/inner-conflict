using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shame : GameCharacter
{
    public float m_health = 100f;
    private float m_maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        m_maxHealth = m_health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damageToTake)
    {
        m_health -= damageToTake;
        float normalScale = 2f;

        transform.localScale = new Vector3(normalScale, normalScale) * (m_health / m_maxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Shame trigger");
        if (collision.transform.GetComponent<Hitbox>())
        {
            float dmg = collision.transform.GetComponent<Hitbox>().attackStrength;
            TakeDamage(dmg);
            Destroy(collision.transform.GetComponent<Hitbox>());
        }
    }
}
