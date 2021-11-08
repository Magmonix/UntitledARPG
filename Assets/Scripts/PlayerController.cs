using System;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public GameObject target;

    void Start()
    {

    }

    void Update()
    {
        if (AttackInteractCheck()) return;
        if (MoveToCheck()) return;
    }

    bool AttackInteractCheck() //Weird interaction if you click the Player GameObject
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);
            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.gameObject.GetComponent<IsAttackable>())
                {
                    target = hit.collider.gameObject;
                    GetComponent<Combat>().Attack(target);
                    return true;
                }
                else if (hit.collider.gameObject.GetComponent<IsInteractable>())
                {
                    target = hit.collider.gameObject;
                    GetComponent<Interact>().InteractWith(target);
                    return true;
                }
            }
        }
        return false;
    }

    bool MoveToCheck()
    {
        RaycastHit Hit;
        bool hasHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out Hit);
        if (hasHit)
        {
            if (Input.GetMouseButtonDown(0))
            {
                target = null;
                GetComponent<PlayerMovement>().MoveTo(Hit.point);
            }
            return true;
        }
        return false;
    }
}
