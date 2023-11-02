using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private float _xVelocity;
    private float _yVelocity;
    public float speed = 3;


    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


   void Update()
    {

        _xVelocity = Input.GetAxis("horizontal") * speed;
        _yVelocity = Input.GetAxis("vertical") * speed;
        _rigidbody2D.velocity = new Vector2(_xVelocity, _yVelocity);
    }
}
