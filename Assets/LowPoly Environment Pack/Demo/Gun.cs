
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    AudioSource m_ShootingSound;

    public Camera fpsCam;

    void Start(){
        m_ShootingSound = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update(){
        if (Input.GetButtonDown("Fire1")){
            Shoot();
            m_ShootingSound.Play();
        }
        
    }
    void Shoot(){
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
        }
    }
}
