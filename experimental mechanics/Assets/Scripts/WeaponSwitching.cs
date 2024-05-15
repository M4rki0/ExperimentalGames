using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public GameObject[] weapons;
    private GameObject currentWeapon;

    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (other.gameObject == weapons[i])
            {
                PickUpWeapon(weapons[i]);
                break;
            }
        }
    }

    void SetActiveWeapon(GameObject newWeapon)
    {
        if (currentWeapon != null)
        {
            currentWeapon.SetActive(false);
        }
        
        currentWeapon = newWeapon;
        if (currentWeapon != null)
        {
            currentWeapon.SetActive(true);
        }
    }
    
    public void PickUpWeapon(GameObject newWeapon)
    {
        SetActiveWeapon(null);
        SetActiveWeapon(newWeapon);
    }
}