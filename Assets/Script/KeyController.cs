using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("DoorExitPoint").GetComponent<DoorController>().CanOpen = true;
            GetComponent<AudioSource>().Play();
            // Destroy(this.gameObject);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            Destroy(transform.parent.gameObject,2f);
        }
    }


}
