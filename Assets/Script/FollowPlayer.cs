using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject vehiclePlayer;
    [SerializeField] Vector3 offset = new Vector3(0, 8, -10); //offset değişkeni kamera ile araç(player) arasındaki mesafe için

    void LateUpdate()
    {
        transform.position = vehiclePlayer.transform.position + offset; //main cameranın aracı takip etmesi için
    }
}
