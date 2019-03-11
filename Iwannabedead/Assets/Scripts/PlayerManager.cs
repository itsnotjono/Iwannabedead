using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerManager : MonoBehaviour
{
    private Vector3 _playerPosition;

    void FixedUpdate()
    {
        _playerPosition = transform.position;

        if (Input.GetKeyDown("up"))
        {
            
        }

        if (Input.GetKeyDown("left") && Input.GetKeyDown("right"))
        {
            // stand still
        }
        else if (Input.GetKey("left"))
        {
            _playerPosition.x -= 0.5f;
            transform.position = new Vector3(_playerPosition.x, _playerPosition.y);
        }
        if (Input.GetKey("right"))
        {
            _playerPosition.x += 0.5f;
            transform.position = new Vector3(_playerPosition.x, _playerPosition.y);
        }
    }
}
