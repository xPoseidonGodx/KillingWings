using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid : MonoBehaviour
{

    [Header("Movement", order = 1)]
    public float speed;

    [Header("Life", order = 2)]
    public int life;
    [Header("Attack", order = 3)]


    public float rechargeTime;

    public int damage;

    public virtual void Movement()
    {

    }
    
    public virtual void Death()
    {

    }

    public virtual void Birth()
    {

    }

    public virtual void LifeLoss()
    {

    }

    public virtual void Attack()
    {

    }

}
