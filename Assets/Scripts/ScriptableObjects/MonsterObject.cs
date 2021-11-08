using UnityEngine;

[CreateAssetMenu]
public class MonsterObject : ScriptableObject
{
    public string MonsterName;
    public int StartingHealth;
    public int BaseMoveSpeed;
    public int BaseAttackSpeed;
    public int BaseDamage;
}