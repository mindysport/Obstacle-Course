//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class KillZone : MonoBehaviour
//{
//    void OnTriggerEnter(Collider col)
//    {
//        System.Diagnostics.Debug.WriteLine("Here");
//        if (col.gameObject.tag == "Player")
//        {
//			col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
//		}
//	}
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Invector.vCharacterController;

public class KillZone : MonoBehaviour
{
    //private Vector3 oldPosition;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            //oldPosition = vThirdPersonController.lastCheckPointPos;
            //System.Console.WriteLine(oldPosition);
            //MainManager.Instance.oldPosition = vThirdPersonController.lastCheckPointPos;
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
            //System.Console.WriteLine(oldPosition);
            //transform.position = oldPosition;
        }
    }
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DieAndRespawn : MonoBehaviour
//{
//    public MainManager gameMaster;


//    void Start()
//    {
//        gameMaster = FindObjectOfType<MainManager>();
//    }

//    void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.tag == "Player")
//        {

//            Debug.Log("Died");

//            gameMaster.RespawnPlayer();

//            Destroy(gameObject);

//        }

//    }
//}