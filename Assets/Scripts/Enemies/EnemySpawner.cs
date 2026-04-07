using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    public float currentTimer;
    public float TimeToSpawn = 2f;

    public float Range = 10f;
    public int AmountEnemiesToSpawn;

    public int MaxEnemiesOnScreen;
    public int currentEnemiesOnScreen;


    public Transform PlayerReference;
    public GameObject EnemyReference;

    void Start()
    {
        GetComponent<SphereCollider>().radius = Range;
        MaxEnemiesOnScreen = 6;
    }

    void Update()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer > TimeToSpawn)
        {
            if (currentEnemiesOnScreen < MaxEnemiesOnScreen)
            {
                for (int i = 0; i < AmountEnemiesToSpawn; i++)
                {

                    SpawnNormalEnemy();

                    currentTimer = 0f;

                    Debug.Log("EnemyCreate");
                }
            }

        }
        if (GameManager.instance.CurrentTime >= 0 && GameManager.instance.CurrentTime < 20)
        {
            TimeToSpawn = 8f;
        }
        if (GameManager.instance.CurrentTime >= 20 && GameManager.instance.CurrentTime < 40)
        {
            TimeToSpawn = 7f;
            MaxEnemiesOnScreen = 8;
        }
        if (GameManager.instance.CurrentTime >= 40 && GameManager.instance.CurrentTime < 60)
        {
            TimeToSpawn = 6f;

            AmountEnemiesToSpawn = 2;
            MaxEnemiesOnScreen = 10;
        }
        if (GameManager.instance.CurrentTime >= 60 && GameManager.instance.CurrentTime < 80)
        {
            TimeToSpawn = 4f;

            AmountEnemiesToSpawn = 3;
            MaxEnemiesOnScreen = 13;
        }
        if (GameManager.instance.CurrentTime >= 80 && GameManager.instance.CurrentTime < 100)
        {
            TimeToSpawn = 2f;

            AmountEnemiesToSpawn = 4;
            MaxEnemiesOnScreen = 16;

        }






    }


    public void SpawnNormalEnemy()
    {


        currentEnemiesOnScreen++;
        GameObject obj = Instantiate(EnemyReference);



        Vector3 origin = transform.position;
        Vector3 dir = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;


        Vector3 finalPositon = origin + dir * Random.Range(0, Range);


        obj.transform.position = finalPositon;




        AgentEnemyController enemy = obj.GetComponent<AgentEnemyController>();


        enemy.spawner = this;
        enemy.Player = PlayerReference;

        int ColorSelected = Random.Range(0, 4);
        switch (ColorSelected)
        {
            case 0:
                enemy.gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;

            case 1:

                enemy.gameObject.GetComponent<Renderer>().material.color = Color.mistyRose;
                break;
            case 2:

                enemy.gameObject.GetComponent<Renderer>().material.color = Color.orange;
                break;

            case 3:

                enemy.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                break;
        }
    }

   

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        Gizmos.DrawWireSphere(transform.position, Range);
    }

}
