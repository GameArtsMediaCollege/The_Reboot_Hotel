using UnityEngine;

public class CloseOnLeave : MonoBehaviour
{
    Animator animator;
    public string closeMessage = "close";
    public string openMessage = "open";

    void Start()
    {
        animator = GetComponent<Animator>();
        if(animator == null)
        {
            Debug.LogError("geen animator gevonden");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool(openMessage, true);
        animator.SetBool(closeMessage, false);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool(closeMessage, true);
        animator.SetBool(openMessage, false);
    }
}
