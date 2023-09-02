using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AvatarHeadConfigure : MonoBehaviour
{
    #region public variables
    public GameObject genericAva;
    public MeshRenderer headMeshRenderer;
    public List<GameObject> avatars = new List<GameObject>();
    #endregion

    #region private variables
    private bool updateFirstAva;
    private bool updateSecondAva;
    private bool updatedAva1;
    private bool updatedAva2;
    #endregion
    
    // Declaration the variables
    private void Awake()
    {
        updateFirstAva = false;
        updateSecondAva = false;
        updatedAva1 = false;
        updatedAva2 = false;
    }

    // Avatars prefabs initialization
    IEnumerator AvatarConfig()
    {
        yield return new WaitForSeconds(1f);
        if (updateFirstAva == true)
        {
            yield return new WaitForSeconds(0.5f);
            avatars[1].SetActive(false);
            avatars[0].SetActive(true);
            Debug.Log("AVA1: head???" + genericAva.transform.GetChild(0).GetChild(0).GetChild(3));
            genericAva.transform.GetChild(0).GetChild(0).GetChild(3).GetComponent<MeshRenderer>().enabled = false;
            updateFirstAva = false;
        }
        if (updateSecondAva == true)
        {
            yield return new WaitForSeconds(0.5f);
            avatars[1].SetActive(true);
            Debug.Log("AVA2: head???" + genericAva.transform.GetChild(0).GetChild(0).GetChild(3));
            genericAva.transform.GetChild(0).GetChild(0).GetChild(3).GetComponent<MeshRenderer>().enabled = false;
            updateSecondAva = false;
        }
    }


    public void Update()
    {
        headMeshRenderer.enabled = false;
        if (PhotonNetwork.CountOfPlayers == 1)
            {
                if (updatedAva1 == false)
                {
                    updateFirstAva = true;
                    StartCoroutine(AvatarConfig());
                    updatedAva1 = true;
                }
            }
      
       
        if (PhotonNetwork.CountOfPlayers > 1)
        {
            if (updatedAva2 == false)
            {
                updateSecondAva = true;
                StartCoroutine(AvatarConfig());
                updatedAva2 = true;
            }
        }
    }
 }
    


