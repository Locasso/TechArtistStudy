using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizeBG : MonoBehaviour
{
    [SerializeField] private Image imgReference; //Referência da imagem que irá receber a cor sorteada.

    void Start()
    {
        imgReference.color = RandomizeBgColor();
    }

    //Método que sorteia e retorna uma cor clara em RGB.
   public Color32 RandomizeBgColor()
    {
        Color32 newColor;

        int[] r = new int[] { 135, 255 };
        int[] g = new int[] { 135, 255 };
        int[] b = new int[] { 135, 255 };

        List<int[]> components = new List<int[]>()
        {
            r,
            g,
            b
        };

        int randomizeComponent = UnityEngine.Random.Range(0, 3);
        int randomizeValue = UnityEngine.Random.Range(0, 2);
        int otherValue;
        int randomizeColor = UnityEngine.Random.Range(135, 256);

        if (randomizeValue == 0)
            otherValue = 1;
        else
            otherValue = 0;

        components[randomizeComponent][0] = randomizeColor;
        components[randomizeComponent][1] = randomizeColor;

        int newR;
        int newG;
        int newB;

        if (components[randomizeComponent] == components[0])
        {
            newR = components[0][randomizeValue];
            newG = components[1][randomizeValue];
            newB = components[2][otherValue];
        }
        else if (components[randomizeComponent] == components[1])
        {
            newR = components[0][otherValue];
            newG = components[1][randomizeValue];
            newB = components[2][randomizeValue];
        }
        else
        {
            newR = components[0][randomizeValue];
            newG = components[1][otherValue];
            newB = components[2][randomizeValue];
        }

        newColor = new Color32((byte)newR, (byte)newG, (byte)newB, (byte)255);
        return newColor;
    }
}
