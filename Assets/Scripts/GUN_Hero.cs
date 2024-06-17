using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUN_Hero : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject reloadingAnim;
    public AudioSource soundReload;
    public GameObject gunFire;
    public Text ReLoadOn;
    private float _timeToShoot;
    private float _T = MAINPARAM._timeToShoot;
    public int _ammoCount;
    private bool _reloaded;
    private float _reloadTime;
    private float _R = 3f;
    void Start()
    {
        _timeToShoot = 0;
        _reloaded = true;
        _ammoCount = 0;
        _reloadTime = _R;
    }

    void Update()
    {
        _timeToShoot -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_ammoCount < 10)
            {
                Shoot();                
            }
            else if (_ammoCount >= 10)
            {
                _reloaded = false;
            }
        }

        if (_reloaded == false)
        {
            reloadAnimOn();
            Reloading();
        }
    }

    public void Reloading()
    {
        _reloadTime -= Time.deltaTime;
        if (_reloadTime <= 0)
        {
            _reloaded = true;
            reloadAnimDone();
            _ammoCount = 0;
            _reloadTime = _R;
        }
    }

    public void Shoot()
    {
        if (_reloaded == true)
        {
            if (_timeToShoot <= 0)
            {
                _ammoCount += 1;
                Instantiate(Bullet, transform.position, Quaternion.identity);
                GunFireSound();
                _timeToShoot = _T;
            }
        }
    }

    public void reloadAnimOn()
    {
        ReLoadOn.enabled = true;
        reloadingAnim.SetActive(true);
        soundReload.enabled = true;
    }

        public void reloadAnimDone()
        {
            ReLoadOn.enabled = false;
            reloadingAnim.SetActive(false);
            soundReload.enabled = false;
    }

        public void GunFireSound()
         {
             Instantiate(gunFire, transform.position, Quaternion.identity);             
         }
    }


