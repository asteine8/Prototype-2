using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float horizontalSpeed;
    public float XBoundryMin;
    public float XBoundryMax;
    private Vector3 hTransform = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Generate horizontal tansform vector
        hTransform = Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput;

        // Check boundries before applying transform
        if ((transform.position + hTransform).x < XBoundryMin) hTransform = Vector3.zero;
        if ((transform.position + hTransform).x > XBoundryMax) hTransform = Vector3.zero; 

        // Apply horizontal transform
        transform.Translate(hTransform);
    }


}
