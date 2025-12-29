using UnityEngine;

public class Projectile : MonoBehaviour
{
    //[SerializeField] public GameObject Player;
    [SerializeField] private Rigidbody projectileRb;
    [SerializeField] private HPManager hpManager;
    [SerializeField] private float projectileSpeed = 3;
    public Vector3 LastLocationOfPlayer;

    void Start()
    {
        transform.LookAt(LastLocationOfPlayer);
        projectileRb.linearVelocity = transform.forward * projectileSpeed;
        //transform.position = Vector3.MoveTowards(transform.position, LastLocationOfPlayer, projectileSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HPBar>())
        {
            Destroy(gameObject);
        }
    }
}
