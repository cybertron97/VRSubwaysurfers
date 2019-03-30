
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject hp_bar;
    public int hp = 100;
    public float yaxis;

    // Start is called before the first frame update
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        yaxis = hp_bar.transform.localScale.y;
        Renderer rend = hp_bar.GetComponent<Renderer>();
        if(collision.collider.tag == "Cube")
        {
            if (yaxis > 0)
            {
                hp -= 25;
                hp_bar.transform.localScale = new Vector3(0.3f, yaxis - 1, 0.3f);
                rend.material.SetColor("_Color", Color.red);
                Debug.Log(hp);
            }
          
          
        }
    }
}
