using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    private bool IsEffectActive = false;

    public abstract void ApplyEffect(Player player);

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
