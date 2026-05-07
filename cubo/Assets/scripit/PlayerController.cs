using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float maxSpeet = 5f;

 
    private Vector2 movementInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    private void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
        Debug.Log("Movement Input: " + movementInput);
    }
    
 




}
