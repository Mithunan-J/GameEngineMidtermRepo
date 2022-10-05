using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float force = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * force);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Fairy"))
        {
            Destroy(collision.gameObject);
            SoundManager._instance.ChangeAudioSpeed(1.5f);
            GameObject.Find("Pitch").GetComponent<TextMeshProUGUI>().text = "Speed " + SoundManager._instance.GetPitch().ToString();
        }
        
    }
}
