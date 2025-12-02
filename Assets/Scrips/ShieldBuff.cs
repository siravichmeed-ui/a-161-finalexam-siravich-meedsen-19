using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
       if (player != null)
       {
           // Implement shield buff logic here
           Debug.Log("Shield Buff Applied to Player!");
        }
    }
}
