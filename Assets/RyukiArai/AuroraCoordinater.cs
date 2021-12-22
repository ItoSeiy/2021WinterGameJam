using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AuroraCoordinater : MonoBehaviour
{
    [SerializeField] Vector2[] Apos;
    float time;
    bool _timeflag;
    [SerializeField]
    float _fadeSpeed;
    float _alpha;
    bool _fadeFlag;
    Image _image;
    void Start()
    {
        _image = GetComponentInChildren<Image>();
        _alpha = _image.color.a;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_fadeFlag)
        {
            FadeOut();
            time += Time.deltaTime;
            Debug.Log(time);
            if (time > 3 && _alpha <= 0)
            {
                _timeflag = true;
                _fadeFlag = true;
                time = 0;
                Debug.Log(_timeflag);
                this.gameObject.transform.position = Apos[(int)Random.Range(0, Apos.Length)];
                
            }
        }
        else
        {
            FadeIn();
        }
    }
    //_fadeFlagがtrueのときはフェードイン
    void FadeIn()
    {
        _alpha += _fadeSpeed * Time.deltaTime;
        _image.color = new Color(255, 255, 255, _alpha);
        if (_alpha >= 1)
        {
            _fadeFlag = false;
        }
    }
    void FadeOut()
    {
        _alpha -= _fadeSpeed * Time.deltaTime;
        _image.color = new Color(255, 255, 255, _alpha);
    }
}
