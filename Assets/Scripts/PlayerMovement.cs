using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float verticalSpeed;
    [SerializeField]
    private float horizontalSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")*horizontalSpeed*Time.deltaTime;
        this.transform.Translate(horizontal, 0, verticalSpeed * Time.deltaTime);
    }
}
