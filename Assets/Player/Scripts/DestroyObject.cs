using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public WinCount winScript;
    private int _destroy;
    
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
