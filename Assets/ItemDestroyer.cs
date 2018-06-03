using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんと除去オブジェクトの距離
    private float difference;
    // Use this for initialization
    void Start ()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんと除去オブジェクトの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Unityちゃんの位置に合わせて除去オブジェクトの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
            
            //接触したオブジェクトを破棄
            Destroy(other.gameObject);
        }
            
    }
     
}
