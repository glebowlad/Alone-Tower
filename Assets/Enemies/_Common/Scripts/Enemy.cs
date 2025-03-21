using AloneTower;
using AloneTower.Towers;
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private AIUnit _aiUnit;
    [SerializeField] private Transform _fireTarget;
    [SerializeField] private EnemyAttack _enemyAttack;
    [SerializeField] private Collider _collider;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private GameObject _visuals;

    public bool _isAlive = true;

    private Tower _tower;

    public AIUnit GetAIUnit() => _aiUnit;
    public GameObject GetVisuals() => _visuals;
    public Collider GetCollider() => _collider;
    public Transform GetFireTarget() => _fireTarget;
    public EnemyAttack GetEnemyAttack() => _enemyAttack;
    public ParticleSystem GetParticleSystem() => _particleSystem;
    public void SetTower(Tower tower) => _tower = tower;
    public Tower GetTower()=> _tower;

    public void SetState(AIUnit.EnemyState targetState)
    {
        _aiUnit.SetState(targetState);
    }


}
