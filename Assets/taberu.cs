using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taberu : MonoBehaviour
{
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
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
