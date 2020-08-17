using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterController : MonoBehaviour
{
    public Joystick joystick;
    public float speed;
    public float FireRate;

    [SerializeField] Animator animator;
    [SerializeField] Transform firePosition;
    Rigidbody rb;

    float moveHorizontal, moveVertical;
    float time;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovementControl();

        time += Time.deltaTime;
        if (time > FireRate)
        {
            time = 0;
            Fire();
        }
    }

    void MovementControl()
    {
        moveHorizontal = joystick.Horizontal;
        moveVertical = joystick.Vertical;

        animator.SetFloat("xAxis", moveHorizontal);

       // transform.position += new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;
       rb.velocity = new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;
    }

    void Fire()
    {
        //Debug.Log(".");
        GameObject obj = ObjectPooler.current.GetPooledObjects();
        if (obj == null)
            return;

        obj.transform.position = firePosition.position;
        obj.transform.rotation = firePosition.rotation;
        obj.SetActive(true);
    }
}
