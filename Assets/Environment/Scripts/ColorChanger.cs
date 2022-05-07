using System.Collections;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    public Color color1;
    public Color color2;

    void Start () {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor() {
   
        while (true) {
      
            if (_spriteRenderer.color == color1)
                _spriteRenderer.color = color2;
      
            else
                _spriteRenderer.color = color1;
      
            yield return new WaitForSeconds(3);
        }
    }
}
