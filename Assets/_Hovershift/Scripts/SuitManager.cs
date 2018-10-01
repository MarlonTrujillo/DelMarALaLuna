using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitManager : MonoBehaviour
{

    private int armorSuitValue;
    private float magnetSuitValue;
    private float invincibleSuitValue;

    private int defaultArmor = 0;
    private float defaultMagnet = 0.1f;
    private float defaultInvincible = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        int caseSwitch = CharacterManager.Instance.CurrentCharacterIndex;

        switch (caseSwitch)
        {
            case 1: // Tier 1 armor
                armorSuitValue = defaultArmor + 1 ;
                magnetSuitValue = defaultMagnet;
                invincibleSuitValue = defaultInvincible;
                break;

            case 2: // Tier 1 magnet
                armorSuitValue = defaultArmor;
                magnetSuitValue = defaultMagnet * 2;
                invincibleSuitValue = defaultInvincible;
                break;

            case 3: // Tier 1 invencibility
                armorSuitValue = defaultArmor;
                magnetSuitValue = defaultMagnet;
                invincibleSuitValue = defaultInvincible * 2;
                break;

            case 4: // Tier 2 armor
                armorSuitValue = defaultArmor + 2 ;
                magnetSuitValue = defaultMagnet;
                invincibleSuitValue = defaultInvincible;
                break;

            case 5: // Tier 2 magnet
                armorSuitValue = defaultArmor;
                magnetSuitValue = defaultMagnet * 3;
                invincibleSuitValue = defaultInvincible;
                break;

            case 6: // Tier 2 invencibility
                armorSuitValue = defaultArmor;
                magnetSuitValue = defaultMagnet;
                invincibleSuitValue = defaultInvincible * 3;
                break;

            case 7: // Tier 3 armor
                armorSuitValue = defaultArmor + 4;
                magnetSuitValue = defaultMagnet;
                invincibleSuitValue = defaultInvincible;
                break;

            case 8: // Tier 3 magnet
                armorSuitValue = defaultArmor;
                magnetSuitValue = defaultMagnet * 5;
                invincibleSuitValue = defaultInvincible;
                break;

            case 9: // Tier 3 invencibility
                armorSuitValue = defaultArmor;
                magnetSuitValue = defaultMagnet;
                invincibleSuitValue = defaultInvincible * 5;
                break;

            case 10: // Special Combined suit
                armorSuitValue = defaultArmor + 1;
                magnetSuitValue = defaultMagnet * 4;
                invincibleSuitValue = defaultInvincible * 4;
                break;

            case 21: // Special Combined suit
                armorSuitValue = defaultArmor + 1;
                magnetSuitValue = defaultMagnet * 4;
                invincibleSuitValue = defaultInvincible * 4;
                break;

            default: // Caso default. Traje 0.
                armorSuitValue = defaultArmor;
                magnetSuitValue = defaultMagnet;
                invincibleSuitValue = defaultInvincible;
                break;
        }
        GameManager.Instance.armorUnits = armorSuitValue;
        GameManager.Instance.laserFrequency = invincibleSuitValue;
        GameManager.Instance.magnetFrequency = magnetSuitValue;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
