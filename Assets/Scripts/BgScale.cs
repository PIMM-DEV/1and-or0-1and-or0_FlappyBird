using UnityEngine;

public class BgScale : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Awake() 
    {
        print(spriteRenderer.bounds.size);
        print(spriteRenderer.size);
        print(spriteRenderer.transform);
        print(Camera.main.orthographicSize);
        print(Screen.height);
        print(Screen.width);
        print(Camera.main.pixelHeight);
        print(Camera.main.pixelWidth);
    }
}
