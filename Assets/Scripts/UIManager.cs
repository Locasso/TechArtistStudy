using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Referências de objetos")]
    [SerializeField] private GameObject[] modelsInCanvas; //Modelos 3D dos ícones.
    [SerializeField] private Sprite[] icons; //Sprite dos ícones de cards.
    [SerializeField] private Sprite[] names; //Imagem do texto de nome de cada card.
    [SerializeField] private Sprite[] effects; //Sprite do efeito de cada card.
    [SerializeField] private Sprite[] quantitys; //Imagem do texto de quantidade de cada card.
    [SerializeField] private Material[] materials; //Materiais usados para a partícula de background em PopUpUnlock.


    [Header("Referências de GameObjects na Hierarquia")]
    [SerializeField] private GameObject modelsParent; //Referencia do objeto pai dos modelos.
    [SerializeField] private GameObject popUpUnlockName; //Referência do GO de imagem do nome na PopUpUnlock.
    [SerializeField] private GameObject popUpUnlockAnimatedBg; //Referência da partícula de background na PopUpUnlock.
    [SerializeField] private GameObject popUpUnlockEffect; //Referência do GO efeito em sprite na PopUpUnlock.
    [SerializeField] private GameObject popUpUnlockQuantity; //Referência do GO de imagem do texto de quantidade na PopUpUnlock.

    public void Start()
    {   
        //Cálculo do Z do objeto pai dos modelos, para mantê-los em proporções parecidas em diferentes resoluções.
        modelsParent.transform.position = new Vector3(modelsParent.transform.position.x, modelsParent.transform.position.y, 
        (modelsParent.transform.position.z * Screen.dpi / (Screen.height + Screen.width)));
    }

    //Invoca as funções para setar os objetos corretos quando o usuário clica em comprar em algum dos cards disponíveis.
    public void ChoosedCard(int id)
    {
        SetGOActive(id, modelsInCanvas);
        SetParticleMaterial(id, materials, popUpUnlockAnimatedBg);
        SetGOSprite(id, names, popUpUnlockName);
        SetGOSprite(id, effects, popUpUnlockEffect);
        SetGOSprite(id, quantitys, popUpUnlockQuantity);
    }

    //Seta o sprite da Imagem "reference" de acordo com o "id" em "objArray".
    void SetGOSprite(int id, Sprite[] objArray, GameObject reference)
    {
        reference.GetComponent<Image>().sprite = objArray[id];
    }

    //Seta o material da Partícula "reference" de acordo com o "id" em "objArray".
    void SetParticleMaterial(int id, Material[] objArray, GameObject reference)
    {
        reference.GetComponent<ParticleSystemRenderer>().material = objArray[id];
    }

    //Seleciona apenas um objeto de "objArray" para estar ativo, de acordo com o "id" passado.
    void SetGOActive(int id, GameObject[] objArray)
    {
        for (int i = 0; i <= objArray.Length - 1; i++)
        {
            if (i != id)
                objArray[i].SetActive(false);
        }
    }
}
