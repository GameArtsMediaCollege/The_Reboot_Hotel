using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("open", true);
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetBool("open", false);
    }
}
