using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject Explosion;
    public float TimeToExplode;
    void Start()
    {
        Destroy(gameObject, TimeToExplode);
        
    }

    void Update()
    {
        
    }
    private void OnDestroy()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
    }


}
