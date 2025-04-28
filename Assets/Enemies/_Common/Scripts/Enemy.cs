using AloneTower;
using AloneTower.Towers;
using System.Collections;
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private AIUnit _aiUnit;
    [SerializeField] private Transform _fireTarget;
    [SerializeField] private EnemyAttack _enemyAttack;
    [SerializeField] private Collider _collider;
    [SerializeField] private ParticleSystem _deadEffect;
    [SerializeField] private GameObject _visuals;
    [SerializeField] private Animator _animator;

    public bool _isAlive = true;

    private Tower _tower;

    public Animator Animator => _animator;

    public AIUnit GetAIUnit() => _aiUnit;
    public GameObject Visuals => _visuals;
    public Collider Collider => _collider;
    public Transform GetFireTarget() => _fireTarget;
    public EnemyAttack GetEnemyAttack() => _enemyAttack;
    public ParticleSystem DeadEffect => _deadEffect;
    public void SetTower(Tower tower) => _tower = tower;
    public Tower GetTower()=> _tower;

    private BaseState _state;

    private void Awake()
    {
        SetState(new EnemyRunState(this));
    }

    private void Update()
    {
        _state.Update();
    }

    public void Attack() // called from attack animation timeline
    {
        _enemyAttack.Attack();
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

    private IEnumerator DestroyEnemy()
    {
        Debug.Log($"{gameObject.GetInstanceID()}");
        _deadEffect.Play();
        GameObject.Destroy(Visuals);
        _collider.enabled = false;

        yield return new WaitForSeconds(0.4f);
        GameObject.Destroy(gameObject);
        yield return null;
    }

}
