using UnityEngine;

public class Monster : MonoBehaviour
{
    public string MonsterName;
    public int Health;
    public int MoveSpeed;
    public int AttackSpeed;
    public int Damage;

    public MonsterType Type;

    void Start()
    {
        MonsterName = Type.MonsterName;
        Health = Type.StartingHealth;
        MoveSpeed = Type.BaseMoveSpeed;
        AttackSpeed = Type.BaseAttackSpeed;
        Damage = Type.BaseDamage;
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