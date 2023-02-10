// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Tobii.Gaming;

// public class PlayerController : MonoBehaviour
// {
//     public bool canMove = true;
    
//     [SerializeField]
//     float maxPos;
    
//     [SerializeField]
//     float moveSpeed;

//     private GazePoint gazePoint;

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (canMove)
//         {
//             MoveWithEyeTracking();
//         }
//     }

//     private void MoveWithEyeTracking()
//     {
//         gazePoint = TobiiAPI.GetGazePoint();
        
//         if (gazePoint.IsRecent())
//         {
//             float inputX = gazePoint.Screen.x * 2 - 1;
//             transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

//             float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
//             transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool canMove = true;

    [SerializeField]
    float maxPos;
    
    [SerializeField]
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x,-maxPos, maxPos);

        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        
    }
}
