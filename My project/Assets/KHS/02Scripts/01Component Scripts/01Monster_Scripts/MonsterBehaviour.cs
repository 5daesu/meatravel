using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterBehavior : MonoBehaviour
{
    private enum State { }

    //Current Moster Infomation
    private float curHp;
    private float atkPower;
    private float defPower;
    private float moveSpeed;

    private State curState;

    void Awake()
    {
        curHp = GetComponent<MonsterInfo>().maxHp;
        atkPower = GetComponent<MonsterInfo>().atkPower;
        defPower = GetComponent<MonsterInfo>().defPower;
        moveSpeed = GetComponent<MonsterInfo>().moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //check tag, if it is player? call DoDamage
    }

    private void DoDamage()
    {

    }

    public void ChangeHp(float amount)
    {
        curHp += amount;
    }

    abstract public void ChangeState();
}
