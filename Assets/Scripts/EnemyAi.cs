using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    private Animator animator;
    private Transform target;
    public float speed;

    [SerializeField] private ItemDrop itemDrop;
    [SerializeField] private bool hasBonusDrop = false;

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
            if (hasBonusDrop)
            {
                Debug.Log("Item droped!");
                GameObject newItem = Instantiate(itemDrop.DropItem());
                newItem.transform.position = transform.position;
            }
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
}
