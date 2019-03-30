using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GunScript : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audioSource;
    public float timer;
    public Transform gunBarrelTransform;
    public GameObject player;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
        timer = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        timer += Time.deltaTime;
    
        if(timer>0.5 &&OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            audioSource.Play();
            RaycastGun();
            timer = 0;
        }  
    }

    private void RaycastGun()
    {
        RaycastHit hit;
        if(Physics.Raycast(gunBarrelTransform.position,gunBarrelTransform.up, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Cube"))
            {
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.CompareTag("Start"))
            {
               // Destroy(hit.collider.gameObject);
                Renderer rend = start.GetComponent<Renderer>();
                rend.material.SetColor("_Color", Color.red);
                start.transform.position = new Vector3(-10.0f, 0, 1);
                //player.transform.position = new Vector3(0, 1.125f, 1.0f);
            }
            
            if (hit.collider.gameObject.CompareTag("restart"))
            {
                SceneManager.LoadScene("Runner");
            }
        }
    }
}
