using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventZone : MonoBehaviour
{
    //表示させたい物
    [SerializeField] GameObject _showImage = default;
   // bool _isshowImage = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.tag=="Player")
        {

       //     _isshowImage = true;
            _showImage.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision1)
    {
        if (collision1.gameObject.tag == "Player")
        {


            _showImage.SetActive(false);

        }
    }


}
