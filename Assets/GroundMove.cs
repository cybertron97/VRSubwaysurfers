
using UnityEngine;
using UnityEngine.SceneManagement;
public class GroundMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody ground;
    public GameObject GameScore;
    public GameObject hp_bar;
    public GameObject player;
    public GameObject start;
    public GameObject restart;
    public float hp;
    public int score;
    public float speed;
    public float time;
    public bool endGame;
    void Start()
    {
     
        score = 0;
        time = 0;
        speed = 0;
        endGame = true;
        hp = hp_bar.transform.localScale.y;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Renderer rend = start.GetComponent<Renderer>();
        Renderer re = restart.GetComponent<Renderer>();
        if (rend.material.color == Color.red && hp != 0)
        {
            endGame = false;
        }

        //ground.velocity = new Vector3(0, 0, speed);
       //  hp = hp_bar.transform.localScale.y;
        if (!endGame)
        {
            hp = hp_bar.transform.localScale.y;
            time = time + Time.deltaTime;
            speed = -10 * time / (time + 1);
            ground.velocity = new Vector3(0, 0, speed);
            score += 0b101;
            GameScore.GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        }
     
        if (hp == 0 && !endGame)
        {
            player.transform.localPosition = new Vector3(65, -30, -184);
            speed = 0;
        
            ground.velocity = new Vector3(0, 0, speed);
            ground.transform.position = new Vector3(0, 0, 750);
            endGame = true;
            time = 0;
            //hp_bar.transform.localScale.y;
        }
        
    }
}
