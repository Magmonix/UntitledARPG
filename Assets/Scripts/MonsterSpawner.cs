using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    Object slime;
    bool monsterSpawning = false;

    void Start()
    {
        slime = Resources.Load("Prefabs/Slime");
        Instantiate(slime);
    }

    void Update()
    {
        Monster[] monsters = FindObjectsOfType<Monster>();
        if (monsters.Length == 0 && monsterSpawning == false)
        {
            monsterSpawning = true;
            Invoke("SpawnMonster", 1f);
        }
    }

    void SpawnMonster()
    {
        Instantiate(slime);
        monsterSpawning = false;
    }
}
