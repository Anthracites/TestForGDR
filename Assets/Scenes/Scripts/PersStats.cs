using System.Collections; 
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PersStats : MonoBehaviour // движение персонажа на сцене
{
    public bool IsKeyTaked = false;// Взят ли ключ от уровня
    public float Speed = 1; // скорость перса   
    public float Size; // размер 
    public float jumpforce = 10f; // сила прыжка
    public bool IsFly = false; // полет
    public bool IsNeuyas = false; // неуязвимость


    public Vector3 MoveVector;
    public GameObject GamePad;
    public int jumpCount;
    private MobileGamePad MobileContr;
    private Rigidbody rb;
    private Vector3 jmp;
    public bool IsStaeyd = false;


    void Start()
    {
        jumpCount = 0; 
        rb = GetComponent<Rigidbody>();
        jmp = transform.up * jumpforce;

        MobileContr = GamePad.GetComponent<MobileGamePad>();
        float dist = Vector3.Distance(transform.position, Camera.main.transform.position);
    }

  void Update()
    {
        //Jump();
        {
            PersMoveAWSD();
        }
      
    }

    void PersMoveAWSD()
    {
        MoveVector = Vector2.zero;
        MoveVector.x = MobileContr.Horizontal() * Speed;
        MoveVector.z = MobileContr.Vertical() * Speed;
        transform.Translate(MoveVector * Time.deltaTime);

    }

    void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) & (jumpCount <= 2) & (IsStaeyd == true))
        {
            rb.AddForce(jmp, ForceMode.Impulse);
            jumpCount++;
            
        }
        else 
        {
            jumpCount = 0;
            IsStaeyd = false;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        IsStaeyd = true;
    }

}
