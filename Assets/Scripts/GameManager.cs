using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public EnemySpawner spawner;


    public float TimeToWin = 100f;

    public float CurrentTime= 0f; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

    }

    void Update()
    {
        CurrentTime += 1 * Time.deltaTime;

        if(CurrentTime >= TimeToWin)
        {
            
        }
    }
}
