using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 1;

    private Dependencies _dep;
    private Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _dep = Dependencies.Instance;
        _dep.RegisterDependency<Player>(this);
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
