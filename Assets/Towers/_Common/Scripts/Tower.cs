using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AloneTower.Towers
{
    public class Tower : MonoBehaviour
    {
        [SerializeField] private SoundController _soundController;
        [SerializeField] private Transform _towerHead;
        [SerializeField] private Transform _towerBarrel;
        [SerializeField] private Transform _target;
        [SerializeField] private float _fireSpeed;
        [SerializeField] private Transform _firePoint;
        [SerializeField] private float _aimRotationSpeed;
        [SerializeField] private float _attackRadius;
        [SerializeField] private ParticleSystem _VFXFire;
        [SerializeField] private Slider _healthSlider;
        [SerializeField] private ParticleSystem _deadEffect;
        [SerializeField] private GameObject _restartButton;

        public ParticleSystem DeadEffect => _deadEffect;
        public float AimRotationSpeed => _aimRotationSpeed;
        public GameObject RestartButton => _restartButton;
        public float AttackRadius => _attackRadius;
        public Slider HealthSlider => _healthSlider;
        public Transform Head => _towerHead;
        public float FireSpeed => _fireSpeed;
        public Transform Barrel => _towerBarrel;
        private BaseState _state;

        private void Awake()
        {
            _restartButton.SetActive(false);
            SetState(new TowerIdleState(this));
        }

        public void SetState(BaseState nextState)
        {
            if (nextState == null)
            {
                Debug.Log($"Next state is null");
                return;
            }

            _state?.Exit();
            _state = nextState;
            _state.Entry();
        }

        private void Update()
        {
            _state.Update();
            if (_healthSlider.value <= 0) 
                SetState( new TowerDeadState(this));
        }
    }
}
