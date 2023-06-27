using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float sensitivity = 10f;
    public float maxYAngle = 80f;
    private Vector2 currentRotation;
    public bool canGrapple = false;
    Camera cam;
    LineRenderer lineRenderer;

    //Weapon variables
    public ParticleSystem muzzleFlash;
    public float damage = 10f;
    public float range = 100f;
    public float hitForce = 10f;
    public GameObject bullet;
    public GameObject transformPos;
    public GroundCheck gc;
    public float grappleDistance = 10f;
    public float grappleForce = 400;
    RaycastHit grappleHit;
    Vector3 grapplePos;
    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        DetectGrappleDistance();

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Jump"))
        {
            if(gc.isOnGround)
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Grapple();
        }
        else
        {
            rb.useGravity = true;
        }

        if(Input.GetMouseButton(1))
        {
            rb.AddForce((grapplePos - transform.position) * grappleForce * Time.deltaTime);
            lineRenderer.enabled = true;
        }
        else
        {
            //SSgrapplePos = transform.position;
            lineRenderer.enabled = false;
        }
        lineRenderer.SetPosition(0, transformPos.transform.position);
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void LateUpdate()
    {
        RotateCamera();
    }

    void Movement()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;

        float moveZ = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        rb.AddForce(transform.forward.normalized * moveZ, ForceMode.Impulse);

        rb.AddForce(transform.right.normalized * moveX, ForceMode.Impulse);

    }

    void RotateCamera()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);

        gameObject.transform.rotation = Quaternion.Euler(0, currentRotation.x, 0);

        cam.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
    }

    void Shoot()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            //Debug.Log(hitInfo.transform.gameObject.name);


            //Get the Target script off the hit object
            Target target =
            hitInfo.transform.gameObject.GetComponent<Target>();
            //If a target script was found, make the target take damage
            if (target != null)
            {
                //Instantiate(bullet, transformPos.transform);
                target.SpawnBullet(hitInfo.point, cam.transform.rotation);
                if (target.CompareTag("Enemy"))
                {
                    target.TakeDamage(damage);
                }
            }

            //If the shot hits a Rigidbody, apply a force
            if (hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }
        }

        //At the beginning of the Shoot() method, play the particle effect
        muzzleFlash.Play();
    }

    void Grapple()
    {

        if(canGrapple)
        {
            rb.useGravity = false;
            //rb.AddForce((grappleHit.point - transform.position) * 200f * Time.deltaTime);
            grapplePos = grappleHit.point;
            lineRenderer.SetPosition(1, grappleHit.point);
            Debug.Log("Grapple point: " + grappleHit.point);
        }
        else
        {
            rb.useGravity = true;
            lineRenderer.enabled = false;
        }
    }

    void DetectGrappleDistance()
    {

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out grappleHit, grappleDistance))
        {
            canGrapple = true;
        }
        else
        {
            canGrapple = false;
        }
    }

}
