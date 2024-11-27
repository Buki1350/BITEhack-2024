using Unity.VisualScripting;
using UnityEngine;

public class PickupCollider : MonoBehaviour
{
    public PlayerEquipment playerEquipment;
    public int pickableLayer;

    void Start()
    {
        pickableLayer = LayerMask.NameToLayer("Pickable");
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == pickableLayer)
        {
            if (Input.GetKeyDown(playerEquipment.pickupKey))
            {
                GameObject newEquippedItem = Instantiate(other.gameObject);
                newEquippedItem.name = other.gameObject.name;
                playerEquipment.equipment.Add(newEquippedItem);
                Destroy(other.gameObject);
            }
        }
    }
}
