using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int n = 0;
    public TextMeshPro nDisplay;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UpdateDisplay();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D or ←/→
        float moveZ = Input.GetAxis("Vertical");   // W/S or ↑/↓

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        rb.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);
    }

    // 値を代入する処理（外部から呼べる）
    public void SetN(int newValue)
    {
        n = newValue;
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
