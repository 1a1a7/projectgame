using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveForce = 10f;
    public int n = 0;
    public TextMeshPro nDisplay;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UpdateDisplay();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        rb.AddForce(movement * moveForce);
    }

    public void SetN(int newValue)
    {
        n = newValue;
        nDisplay.text = "n = " + n;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (nDisplay != null)
        {
            nDisplay.text = $"n = {n}";
        }
    }
}
