using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController _controller;
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _gravity = 1f;
    [SerializeField]
    private float _jumpHeight = 30.0f;
    private float yVelocity;
    private bool _canDoubleJump = true;
    [SerializeField]
    private int _score =0;
    private UiManager _uiManager;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalInput, 0, 0);
        Vector3 velocity = direction * _speed;

        if (_controller.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _canDoubleJump = true;
                yVelocity = _jumpHeight;
            }
        }
        else
        {
            if(_canDoubleJump && Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity += _jumpHeight;
                _canDoubleJump = false;
            }
            yVelocity -= _gravity;
        }

        velocity.y = yVelocity;


        _controller.Move(velocity * Time.deltaTime);
    }

    public void AddCoins()
    {
        _score++;
        _uiManager.UpdateScore(_score);
    }
}
