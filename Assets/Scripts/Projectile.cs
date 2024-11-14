using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move projectile forward at projectileSpeed
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);
    }
}
