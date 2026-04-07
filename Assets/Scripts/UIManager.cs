using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI currentEnemies;

    void Start()
    {
        
    }

    void Update()
    {
        Timer.text = "Time:" + GameManager.instance.CurrentTime;
        currentEnemies.text = "CurrentEnemies: " + GameManager.instance.spawner.currentEnemiesOnScreen;

    }
}
