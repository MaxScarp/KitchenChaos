using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Recipe")]
public class RecipeSO : ScriptableObject
{
    public string nameString;
    public List<KitchenObjectSO> kitchenObjectSOList;
}
