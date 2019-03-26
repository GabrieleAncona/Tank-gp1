using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Projectile", menuName = "Projectile")]
public class ProjectileData : ScriptableObject, IDestructable
{
    public float Damage;
    public float Speed;
    public GameObject projectileview;
}
