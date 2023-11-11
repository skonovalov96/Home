using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Learningcurve : MonoBehaviour
{
    public Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;



    void Start()
    {
          Weapon huntingBow = new(" Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = " War Bow";
        warBow.damage = 100;

    huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
       
        var hero = new Character();
        Character hero2 = hero;
        hero2.name = " Stos";
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
         

        Paladin knight = new Paladin(" sir Vlad", huntingBow);
        knight.PrintStatsInfo();

         camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        

        Character heroine = new Character("Born");
       heroine.PrintStatsInfo();

        //directionLight = GameObject.Find("Directional Light");

        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
      
    }
}
