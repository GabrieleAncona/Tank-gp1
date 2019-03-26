using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Projectile", menuName = "Projectile")]
public class ProjectileData : ScriptableObject, IDestructable
{
    [Range(0, 1)]
    public float Damage;
    public float Speed;
    public GameObject projectileview;
    public float range;
    public float maxRange;
    public ShootType shoottype;
}

public enum ShootType
{
    Missile
}
