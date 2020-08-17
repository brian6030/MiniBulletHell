using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float ProjectileSpeed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * ProjectileSpeed;
    }

    void OnEnable()
    {
        if (rb != null)
            rb.velocity = Vector3.forward * ProjectileSpeed;

        Invoke("Disable", 2f); 
    }

    void Disable()
    {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke();
    }
}
