using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Humanoid
{
    public List<GameObject> shotList = new List<GameObject>(3);
    public GameObject shot;
    GameObject bulletIndicator;

    Rigidbody2D _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Start() {
        bulletIndicator = GameObject.Find("BulletIndicator");
    }

    void Update()
    {
        Movement();
        Attack();
    }

    public override void Movement()
    {
        base.Movement();

        float horizontal = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(speed * horizontal * Time.deltaTime, _rb.velocity.y);
        
    }

    public override void Attack()
    {
        base.Attack();
        if(Input.GetMouseButtonDown(0) )
        {
            CallShot();
        }
    }

    void CallShot()
    {
        GameObject shotTemp = null;
        shotTemp = Instantiate(shot, bulletIndicator.transform.position, Quaternion.identity);
        shotList.Add(shot);
    }

    
}
