using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator animator; 
    void Start()
    {
        animator = GetComponent<Animator>();
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
        animator.SetBool("open", false );
    }
}
