using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float sensitivity = 10f;
    public float maxYAngle = 80f;
    private Vector2 currentRotation;
    Camera cam;

    //Weapon variables
    public ParticleSystem muzzleFlash;
    public float damage = 10f;
    public float range = 100f;
    public float hitForce = 10f;
    public GameObject bullet;
    public GameObject transformPos;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        RotateCamera();

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Movement()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(moveX , 0f, moveZ);
    }

    void RotateCamera()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
        cam.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);

        gameObject.transform.rotation = Quaternion.Euler(0, currentRotation.x, 0);
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
                target.TakeDamage(damage);
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

}
