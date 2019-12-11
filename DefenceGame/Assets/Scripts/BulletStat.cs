using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//VO: Value Object
public class BulletStat
{
    public float speed { get; set; }
    public int damage { get; set; }
    
    public BulletStat(float _speed, int _damage)
    {
        this.speed = _speed;
        this.damage = _damage;
    }

}
