using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject[] modelsInCanvas;
    [SerializeField] private Sprite[] icons;
    [SerializeField] private Sprite[] names;
    [SerializeField] private Sprite[] effects;
    [SerializeField] private Sprite[] quantitys;
    [SerializeField] private Material[] materials;

    [SerializeField] private GameObject popUpUnlockName;
    [SerializeField] private GameObject popUpUnlockAnimatedBg;
    [SerializeField] private GameObject popUpUnlockEffect;
    [SerializeField] private GameObject popUpUnlockQuantity;

    public void ChoosedCard(int id)
    {
        SetGOActive(id, modelsInCanvas);
        SetParticleMaterial(id, materials, popUpUnlockAnimatedBg);
        SetGOSprite(id, names, popUpUnlockName);
        SetGOSprite(id, effects, popUpUnlockEffect);
        SetGOSprite(id, quantitys, popUpUnlockQuantity);
    }

    void SetGOSprite(int id, Sprite[] objArray, GameObject reference)
    {
        reference.GetComponent<Image>().sprite = objArray[id];
    }

    void SetParticleMaterial(int id, Material[] objArray, GameObject reference)
    {
        reference.GetComponent<ParticleSystemRenderer>().material = objArray[id];
    }

    void SetGOActive(int id, GameObject[] objArray)
    {
        for (int i = 0; i <= objArray.Length - 1; i++)
        {
            if (i != id)
                objArray[i].SetActive(false);
        }
    }
}
