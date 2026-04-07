using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public EnemySpawner spawner;


    public int TimeToWin = 100;

    public int CurrentTime= 0; 

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
        CurrentTime += Mathf.RoundToInt(1 * Time.deltaTime);

        if(CurrentTime >= TimeToWin)
        {
            
        }
    }
}
