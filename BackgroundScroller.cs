using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // For learning how to use this script please visit https://www.breakmeinfo.com/2021/05/how-to-make-scrolling-background-in-unity3d.html

    private Material material; 
    
    public Vector2 scrollingSpeed;  // Set scrolling speed and angle in horizontal and vertical direction in inspector

    private void Start()
    {
        material = GetComponent<Renderer>().material; // Get current object material
    }

    private void Update()
    {
        material.mainTextureOffset += scrollingSpeed * Time.deltaTime;
    }
}
