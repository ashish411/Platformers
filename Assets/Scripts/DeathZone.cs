using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField]
    private GameObject _respwanPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.RemoveLive();
  
            CharacterController cc = player.GetComponent<CharacterController>();
            cc.enabled = false;

            other.transform.position = _respwanPoint.transform.position;

            StartCoroutine(CcEnableController(cc));
        }
    }

    IEnumerator CcEnableController(CharacterController cc)
    {
        yield return new WaitForSeconds(1f);   
        cc.enabled = true;
    }
}
