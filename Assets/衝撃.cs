using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 衝撃 : MonoBehaviour
{
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 砲弾が当たった時
        if (collision.gameObject.tag == "Player")
        {

            AudioSource.PlayClipAtPoint(clip, transform.position);

            // AudioSource コンポーネントを取得して音を鳴らす
            //  AudioSource audio = GetComponent<AudioSource>();
            //  audio.Play();
            // 自分自身を破棄する

            Destroy(this.gameObject);
        }
    }
}
        
