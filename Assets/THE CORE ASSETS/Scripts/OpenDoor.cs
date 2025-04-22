using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator animator;
    private AudioSource dooraudio;
    void Start()
    {
        animator = GetComponent<Animator>();
        dooraudio = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("open", true);
        dooraudio.Play();
    }

    void OnTriggerExit(Collider other)
    {
        animator.SetBool("open", false );
        dooraudio.Play();
    }
}
