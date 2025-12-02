using UnityEngine;

public class Damage : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (player != null)
        {

            Debug.Log("damage");
        }
    }
}
