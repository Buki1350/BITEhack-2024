using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    [SerializeField] float pickupRadius = 5f;
    [SerializeField] public KeyCode pickupKey = KeyCode.E;
    public List<GameObject> equipment = new List<GameObject>(5);
    void Start()
    {
        
    }
    
    void Update()
    {
    
    }
    
    
}
