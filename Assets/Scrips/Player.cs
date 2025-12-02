using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private int health = 100;
    [SerializeField]private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField]private bool isInvulnerable = false;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PowerUpBase powerUp = other.GetComponent<PowerUpBase>();
        if (powerUp != null)
        {
            if (powerUp is SpeedBoost)
            {
                moveSpeed *= 10f;
            }
            else if (powerUp is ShieldBuff)
            {
                isInvulnerable = true;
            }
            
            else if (powerUp is Damage)
            {
                if (!isInvulnerable)
                {
                    health -= 20;
                }
            }

            powerUp.ApplyEffect(this);
            Destroy(other.gameObject);
        }
    }

}
