using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameObject skinCar;
    void Update()
    {
        PlayerMove();   
    }

    private void PlayerMove()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);
    }
}
