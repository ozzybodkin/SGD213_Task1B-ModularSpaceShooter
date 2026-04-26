using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    //This varible dertermines how often the player can shoot a projectile
    [Header("Controls")]
    [SerializeField]
    protected float fireDelay = 1f;

    //This carible is a refrance to the bullet object
    [SerializeField]
    protected GameObject bullet;
    public GameObject Bullet
    {
        get { return bullet; }
        set { bullet = value; }
    }

    //These varibles are a refrance to the location where the bullets will spawn when they are fired
    [Header("References")]
    [SerializeField]
    protected Transform bulletSpawnPoint;
    public Transform BulletSpawnPoint
    {
        get { return bulletSpawnPoint; }
        set { bulletSpawnPoint = value; }
    }

    // This varible keeps track of how long its been since the last bullet was fired
    protected float lastFiredTime = 0f;

    //This function will be called from other scripts when a bullet needs to be fired
    public abstract void Shoot();

    //This script updates the weapon conrtols to the new weapon when the player changes weapons
    public virtual void UpdateWeaponControls(WeaponBase oldWeapon)
    {
        // update the data of the new weapon with the data from this weapon
        bulletSpawnPoint = oldWeapon.BulletSpawnPoint;
        bullet = oldWeapon.Bullet;
    }
}
