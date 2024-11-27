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
            Debug.Log(other.gameObject.name);
            if (Input.GetKeyDown(playerEquipment.pickupKey))
            {
                GameObject newEquippedItem = other.gameObject;
                playerEquipment.equipment.Add(other.gameObject);
                Destroy(newEquippedItem);
            }
        }
    }
}
