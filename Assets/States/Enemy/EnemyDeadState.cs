using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeadState : BaseState
{
    private Enemy _enemy;
    private ParticleSystem _deadEffect;
    private GameObject _visuals;
    private Collider _collider;
    public EnemyDeadState(Enemy enemy)
    {
        _enemy = enemy;
        _deadEffect = _enemy.DeadEffect;
        _visuals = _enemy.Visuals;
        _collider = _enemy.Collider;
    }
    public override void Entry()
    {
        base.Entry();
        DestroyEnemy(_enemy);
       
        
    }


    public override void Update()
    {
        base.Update();
    }
    public override void Exit()
    {
        base.Exit();
    }
    private void DestroyEnemy(MonoBehaviour enemy)
    {
        enemy.StartCoroutine("DestroyEnemy");
    }


    
}
