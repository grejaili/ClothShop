using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public int Panties_On;
    public int Bras_On;
    public int Top_on;
    public int Bottom_On;
    public int Shoes_On;


    public void RestartCharacterData()
    {
        Panties_On = 0;
        Bras_On = 0;
        Top_on = 0;
        Bottom_On = 0;
        Shoes_On = 0;
    }



    public void NextIndex(List<GameObject> list, int caseIndex)
    {
        switch(caseIndex)
        {
            case 0:
            Panties_On = CheckNextIndex(Panties_On, list.Count);
            break;
            case 1:
            Bras_On = CheckNextIndex(Bras_On, list.Count);
            break;
            case 2:
            Top_on = CheckNextIndex(Top_on, list.Count);
            break;
            case 3:
            Bottom_On = CheckNextIndex(Bottom_On, list.Count);
            break;
            case 4:
            Shoes_On = CheckNextIndex(Shoes_On, list.Count);
            break;
        }

    }
    public void PreviousIndex(List<GameObject> list, int caseIndex)
    {
        switch(caseIndex)
        {
            case 0:
            Panties_On = CheckPreviosIndex(Panties_On, list.Count);
            break;
            case 1:
            Bras_On = CheckPreviosIndex(Bras_On, list.Count);
            break;
            case 2:
            Top_on = CheckPreviosIndex(Top_on, list.Count);
            break;
            case 3:
            Bottom_On = CheckPreviosIndex(Bottom_On, list.Count);
            break;
            case 4:
            Shoes_On = CheckPreviosIndex(Shoes_On, list.Count);
            break;
        }
    }


    public int CheckNextIndex(int _index, int _total)
    {
        if(_index >= _total - 1)
        {
            return 0;
        }

        return ++_index;
    }

    public int CheckPreviosIndex(int _index, int _total)
    {
        if(_index == 0)
        {
            return _total - 1;
        }
        return --_index;

    }






}
