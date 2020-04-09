using System.Collections.Generic;
using UnityEngine;
public class ClothControll : MonoBehaviour
{
    public ClothesReference clothesReference;
    public CharacterData characterData;


    private void Start()
    {
        characterData.RestartCharacterData();
        ActivateUnderwear();
    }


    void ActivateUnderwear()
    {
        clothesReference.underwear_Panties[characterData.Panties_On].SetActive(true);
        clothesReference.underwear_Bras[characterData.Bras_On].SetActive(true);
    }


    public void NextIndexUI(int CaseIndex)
    {
        switch(CaseIndex)
        {
            case 0:
            this.Next(clothesReference.underwear_Panties, CaseIndex, ref characterData.Panties_On);

            break;
            case 1:
            this.Next(clothesReference.underwear_Bras, CaseIndex, ref characterData.Bras_On);
            break;
            case 2:
            this.Next(clothesReference.Top, CaseIndex, ref characterData.Top_on);
            break;
            case 3:
            this.Next(clothesReference.Bottom, CaseIndex, ref characterData.Bottom_On);
            break;
            case 4:
            this.Next(clothesReference.Shoes, CaseIndex, ref characterData.Shoes_On);
            break;
        }


    }

    public void PreviousIndexUI(int CaseIndex)
    {
        switch(CaseIndex)
        {
            case 0:
            this.Previous(clothesReference.underwear_Panties, CaseIndex, ref characterData.Panties_On);

            break;
            case 1:
            this.Previous(clothesReference.underwear_Bras, CaseIndex, ref characterData.Bras_On);
            break;
            case 2:
            this.Previous(clothesReference.Top, CaseIndex, ref characterData.Top_on);
            break;
            case 3:
            this.Previous(clothesReference.Bottom, CaseIndex, ref characterData.Bottom_On);
            break;
            case 4:
            this.Previous(clothesReference.Shoes, CaseIndex, ref characterData.Shoes_On);
            break;
        }
    }

    public void Next(List<GameObject> Clotheslist, int caseIndex, ref int actualIndex)
    {
        Clotheslist[actualIndex].SetActive(false);
        characterData.NextIndex(Clotheslist, caseIndex);
        Clotheslist[actualIndex].SetActive(true);
    }



    public void Previous(List<GameObject> Clotheslist, int caseIndex, ref int actualIndex)
    {
        Clotheslist[actualIndex].SetActive(false);
        characterData.PreviousIndex(Clotheslist, caseIndex);
        Clotheslist[actualIndex].SetActive(true);
    }






    public void ActivateClothes()
    {
        clothesReference.Top[characterData.Top_on].SetActive(true);
        clothesReference.Bottom[characterData.Bottom_On].SetActive(true);
        clothesReference.Shoes[characterData.Shoes_On].SetActive(true);
    }

    public void DeactivateClothes()
    {
        clothesReference.Top[characterData.Top_on].SetActive(false);
        clothesReference.Bottom[characterData.Bottom_On].SetActive(false);
        clothesReference.Shoes[characterData.Shoes_On].SetActive(false);
    }





}
