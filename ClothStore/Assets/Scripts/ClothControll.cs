using UnityEngine;

public class ClothControll : MonoBehaviour
{
    public ClothesReference clothesReference;
    public CharacterData characterData;


    private void Start()
    {
        ActivateUnderwear();
    }


    void ActivateUnderwear()
    {
        clothesReference.underwear_Panties[characterData.Panties_On].SetActive(true);
        clothesReference.underwear_Bras[characterData.Bras_On].SetActive(true);
    }



    public void NextIndex()
    {

    }





    void ActivateClothes()
    {
        clothesReference.Top[characterData.Top_on].SetActive(true);
        clothesReference.Bottom[characterData.Bottom_On].SetActive(true);
        clothesReference.Shoes[characterData.Shoes_On].SetActive(true);
    }

    void DeactivateClothes()
    {
        clothesReference.Top[characterData.Top_on].SetActive(false);
        clothesReference.Bottom[characterData.Bottom_On].SetActive(false);
        clothesReference.Shoes[characterData.Shoes_On].SetActive(false);
    }





}
