using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInfo : MonoBehaviour
{
    [SerializeField] public float maxHp { get; }
    [SerializeField] public float atkPower { get; }
    [SerializeField] public float defPower { get; }
    [SerializeField] public float moveSpeed { get; }
}