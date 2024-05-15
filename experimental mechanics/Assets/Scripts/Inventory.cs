using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Transform weaponBone;
    public int keys;
    public UseWeapon weapon;

    public void AddKey()
    {
        keys++;
    }
    public void SetWeapon(UseWeapon newWeapon)
    {
        if(weapon) Destroy(weapon.gameObject);
        var newWeaponInst = Instantiate(newWeapon.gameObject, weaponBone.position, Quaternion.identity, transform);
        weapon = newWeaponInst.GetComponent<UseWeapon>();
    }
}