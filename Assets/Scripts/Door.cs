using UnityEditor.Animations;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private BoxCollider collider;

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
            animator.SetBool("playerInFront", true);
            collider.isTrigger = true;
            //animator.Play("Door open", 0, 0.0f);
        }

    }
}
