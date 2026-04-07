using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float ScaleStep = 0.1f;
    public float lifeTime = 1.5f;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        if(transform.localScale.x <= 15 && transform.localScale.y <= 15 && transform.localScale.z <= 15)
        {
            transform.localScale += new Vector3(ScaleStep, ScaleStep, ScaleStep); 
            
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {

            Destroy(other);
        }
    }
}
