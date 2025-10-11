using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    private Animator animator;
    private Transform target;
    public float speed;

    private void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        animator.SetBool("playerInSight", true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Blast"))
        {
            Debug.Log("Enemy Shot");
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
}
