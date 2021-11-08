using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] float interactRange = 3f;

    bool isInteracting = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (!isInteracting && GetComponent<PlayerController>().target != null && GetComponent<PlayerController>().target.GetComponent<IsInteractable>())
        {
            InteractWith(GetComponent<PlayerController>().target);
        }
    }

    public void InteractWith(GameObject target)
    {
        if (GetComponent<PlayerMovement>().InRangeCheck(interactRange, target))
        {
            GetComponent<PlayerMovement>().Stop();
            Debug.Log("You interact with " + target.name);
            GetComponent<PlayerController>().target = null;
        }
        else
        {
            GetComponent<PlayerMovement>().MoveTo(target.transform.position);
        }
    }
}
