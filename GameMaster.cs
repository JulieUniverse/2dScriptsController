using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public AudioClip killPigAudio;
    private AudioSource source;
    public static GameMaster gm;
    public Transform player;
    public Transform spawnPoint;
    private Health health;
    public GameObject gameOverScreen;
    public bool death;
    private Poop poopScript;
    void Start()
    {
        source = GetComponent<AudioSource>();
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    void Awake()
    {
        health = FindObjectOfType<Health>();
        poopScript = FindObjectOfType<Poop>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            KillPlayer();
            //poopScript.SelfDestruct();
            RespawnPlayer();
            GameOverOn();
            //Restart();
            //Invoke("Restart",1f);
        }
        //death = false;
    }

    void KillPlayer()
    {
        death = true;
        source.PlayOneShot(killPigAudio);
        health.lives -= 1;
        Debug.Log(health.lives);
    }
    void RespawnPlayer() {
        //death = false;
        player.transform.position = new Vector2(spawnPoint.position.x, spawnPoint.position.y);
    }

    void Restart()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOverOn()
    {
        if (health.lives <= 0)
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            gameOverScreen.SetActive(true);
        }

    }
}
