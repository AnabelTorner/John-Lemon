using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public GameObject player;
    public bool m_IsPlayerAtSafeZone;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtSafeZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtSafeZone = false;
        }
    }

    void Update()
    {

    }
}
