using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SkinPicker : MonoBehaviour
{

    public List<Material> playerSkins = new List<Material>();
    List<Material> tempMat = new List<Material>();

    private int skinSelection = 0;

    MeshRenderer skin;

    // Start is called before the first frame update
    void Start()
    {
        skinSelection = PlayerPrefs.GetInt("SkinPicked");
        playerSkins = Resources.LoadAll<Material>("Skins").ToList<Material>();
        skin = gameObject.GetComponent<MeshRenderer>();
        Material tmpMat = playerSkins.ElementAt<Material>(skinSelection);
        skin.material = tmpMat;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
