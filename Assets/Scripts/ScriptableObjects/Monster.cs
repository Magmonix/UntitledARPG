using UnityEngine;

public class Monster : MonoBehaviour
{
    public string MonsterName;
    public int Health;
    public int MoveSpeed;
    public int AttackSpeed;
    public int Damage;

    public MonsterObject Object;

    void Start()
    {
        MonsterName = Object.MonsterName;
        Health = Object.StartingHealth;
        MoveSpeed = Object.BaseMoveSpeed;
        AttackSpeed = Object.BaseAttackSpeed;
        Damage = Object.BaseDamage;
    }

    void Update()
    {
        if(Health <= 0)
        {
            MonsterDied();
        }
    }

    void MonsterDied()
    {
        Debug.Log("You killed the " + MonsterName);
        Destroy(gameObject);
    }
}