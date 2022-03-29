using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // 1
    public bool grounded;
    public GameObject Bullet;
    public float BulletSpeed = 100f;
    // 2
    private bool _isShooting;

    public float DistanceToGround = 0.1f;
    
    public LayerMask GroundLayer;
   
    private CapsuleCollider _col;

    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;
    
    private Rigidbody _rb;

    public float JumpVelocity = 5f;
    public bool _isJumping;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
        _col = GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        // 3
        _isShooting = Input.GetMouseButtonDown(0);
        _isJumping = Input.GetKeyDown(KeyCode.Space);
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        /*
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime); */
    }

    void FixedUpdate()
    {
    
        if (IsGrounded() && _isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }
    
        _isJumping = false;

        
        Vector3 rotation = Vector3.up * _hInput;
        
        Quaternion angleRot = Quaternion.Euler(rotation *
            Time.fixedDeltaTime);
        
        _rb.MovePosition(this.transform.position +
            this.transform.forward * _vInput * Time.fixedDeltaTime);
       
        _rb.MoveRotation(_rb.rotation * angleRot);

        // 4
        if (_isShooting)
        {
            // 5
            GameObject newBullet = Instantiate(Bullet,
                this.transform.position + new Vector3(1, 0, 0),
                   this.transform.rotation);
            // 6
            Rigidbody BulletRB =
                 newBullet.GetComponent<Rigidbody>();
            // 7
            BulletRB.velocity = this.transform.forward *
                               BulletSpeed;
        }
        // 8
        _isShooting = false;

    }


    private bool IsGrounded()
    {
    
    Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
    
    grounded = Physics.CheckCapsule(_col.bounds.center,
        capsuleBottom, DistanceToGround, GroundLayer,
            QueryTriggerInteraction.Ignore);
    
    return grounded;
    }
}
