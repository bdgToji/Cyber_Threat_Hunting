using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private BoxCollider collider;
    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip sfx;

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
        if (other.CompareTag("Player"))
        {
            if (!collider.isTrigger)
            {
                src.PlayOneShot(sfx);
            }
            animator.SetBool("playerInFront", true);
            collider.isTrigger = true;
            
            //animator.Play("Door open", 0, 0.0f);
        }

    }
}
