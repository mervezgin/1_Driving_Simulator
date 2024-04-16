using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject vehiclePlayer;
    [SerializeField] Vector3 offset = new Vector3(0, 8, -10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = vehiclePlayer.transform.position + offset;
    }
}
