using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public EnemySpawner spawner;

    public Teleport1 Tp1;

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

    // Update is called once per frame
    void Update()
    {

    }
}
