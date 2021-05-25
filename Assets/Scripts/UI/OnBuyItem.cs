using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class OnBuyItem : MonoBehaviour
{
    public delegate void BoughtItem();
    public static event BoughtItem OnBoughtItem; 
    
    [SerializeField] private GameObject popUpUnlock;
    [SerializeField] private GameObject popUpShop;
    [SerializeField] private GameObject popUpUnlockmModelPlaceHolder;
    [SerializeField] private GameObject popUpUnlockBgParticles;

    public void InvokeBuyItemAnim()
    {
        popUpShop.SetActive(false);
        popUpUnlockBgParticles.SetActive(true);
        popUpUnlockBgParticles.GetComponent<ParticleSystem>().Play();
        popUpUnlock.SetActive(true);
        popUpUnlockmModelPlaceHolder.SetActive(true);
    }
}
