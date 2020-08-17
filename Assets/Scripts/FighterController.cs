using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterController : MonoBehaviour
{
    public Joystick joystick;

    public float speed;

    [SerializeField] Animator animator;
    float moveHorizontal, moveVertical;

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHorizontal = joystick.Horizontal;
        moveVertical = joystick.Vertical;

        animator.SetFloat("xAxis", moveHorizontal);

        transform.position += new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;

    }
}
