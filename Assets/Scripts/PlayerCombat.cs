using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public static PlayerCombat Instance;

    public GameObject bulletPrefab, meleePrefab;

    public float m_health;

    private void Start()
    {
        Instance = this;
    }

    public void CreateBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position;
    }

    void CreateMelee()
    {
        
    }

    public void TakeDamage(float damageToTake)
    {
        m_health -= damageToTake;
    }
}
