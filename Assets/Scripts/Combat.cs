using System;
using UnityEngine;

public class Combat : MonoBehaviour
{
    [SerializeField] float attackRange = 5f;
    [SerializeField] int damage = 5;

    void Start()
    {
        
    }

    void Update()
    {
        if (GetComponent<PlayerController>().target != null && GetComponent<PlayerController>().target.GetComponent<IsAttackable>())
        {
            Attack(GetComponent<PlayerController>().target);
        } 
    }

    public void Attack(GameObject target)
    {
        if(GetComponent<PlayerMovement>().InRangeCheck(attackRange, target))
        {
            GetComponent<PlayerMovement>().Stop();
            Debug.Log("You attack the " + target.GetComponent<Monster>().MonsterName);
            CalculateDamage(target);
            GetComponent<PlayerController>().target = null;
        }
        else
        {
            GetComponent<PlayerMovement>().MoveTo(target.transform.position);
        }
    }

    private void CalculateDamage(GameObject target)
    {
        target.GetComponent<Monster>().Health -= damage;
    }
}
