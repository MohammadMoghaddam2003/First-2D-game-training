using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Weapons : MonoBehaviour
{
    public static weaponesEnum _selectedWeapones;
    public Sprite knife , grenades;
    public Image weaponeImage;

    void Start() 
    {
        _selectedWeapones = weaponesEnum.Knife;
    }

    private void Update() {
        if (_selectedWeapones == weaponesEnum.Knife)
        {
           weaponeImage.sprite = grenades;
           transform.localScale = new Vector3 (1,1,1);
        }
        else
        {
           weaponeImage.sprite = knife;
           transform.localScale = new Vector3 (1,-1,1);
        }
    }

    public void ChangeWeapone()
    {
        if (_selectedWeapones == weaponesEnum.Knife)
        {
            _selectedWeapones = weaponesEnum.Grenades;
        }
        else
        {
            _selectedWeapones = weaponesEnum.Knife;
        }
    }
}

public enum weaponesEnum
{
    Knife,
    Grenades
}