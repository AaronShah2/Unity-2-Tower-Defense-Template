using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Projectile", menuName = "CustomObjects/Projectile")]
public class ProjectileType : ScriptableObject
{
    public int damage; // damage bullet deals
    public float speed; // speed at which bullet goes across the screen
    public float size; // size of the bullets
    public Color color = Color.black; // color of bullet
    public Sprite sprite; // sprite we give our bullet
}
