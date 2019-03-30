
using UnityEngine;

public class movement : MonoBehaviour
{
   
    public Vector3 mainCameraOrigPosition;
    public Vector3 diff;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // time =time+Time.deltaTime;
       // speed = 50 * time / (time + 1);
       // player.velocity=new Vector3(0,0,speed);
        //transform.position = player.transform.position + new Vector3(0, 1, 0);
        //mainCameraOrigPosition = transform.position; //child
        //Debug.Log(mainCamera.transform.position);
        //diff = transform.position - mainCameraOrigPosition; // ? 
        //player.transform.position -= new Vector3(diff.x,0,0);
        


        //var cameraposition = transform.position;
        //var playerposition = player.transform.position;
        //playerposition.x = cameraposition.x;
        //player.transform.position = playerposition;
        //player;
    }
}
