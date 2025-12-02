using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (player != null)
        {
           
            Debug.Log("Speed Boost Applied to Player!");
        }
    }
}
