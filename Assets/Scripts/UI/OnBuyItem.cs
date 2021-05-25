using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class OnBuyItem : MonoBehaviour
{    
    [Header("Referências de GameObject")]
    [SerializeField] private GameObject popUpUnlock; //Referência do objeto base do PopUpUnlock.
    [SerializeField] private GameObject popUpShop; //Referência do objeto base do PopUpShop.
    [SerializeField] private GameObject popUpUnlockmModelPlaceHolder; //Referência do objeto base dos modelos em PopUpUnlock.
    [SerializeField] private GameObject popUpUnlockBgParticles; //Referência do objeto base das partículas de background em PopUpUnlock.

    //Método utilizado no fim da animação de fluxo entre "PopUpShop" e "PopUpUnlock" para fins de transição e setup.
    public void InvokeBuyItemAnim()
    {
        popUpShop.SetActive(false);
        popUpUnlockBgParticles.SetActive(true);
        popUpUnlockBgParticles.GetComponent<ParticleSystem>().Play();
        popUpUnlock.SetActive(true);
        popUpUnlockmModelPlaceHolder.SetActive(true);
    }
}
