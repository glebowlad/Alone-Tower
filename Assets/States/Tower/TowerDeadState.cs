using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AloneTower.Towers;
using AloneTower.SpawnSystem;

public class TowerDeadState : BaseState
{
    private Tower _tower;
    private ParticleSystem _deathVFX;
    private GameObject _restartButton;

    public TowerDeadState(Tower tower)
    {
        _tower = tower;
        _deathVFX= _tower.DeadEffect;
        _restartButton = _tower.RestartButton;
    }

    public override void Entry()
    {
        base.Entry();
        _deathVFX.Play();
        _restartButton.SetActive(true);
    }
    public override void Update()
    {
        base.Update();
    }
    public override void Exit()
    {
        base.Exit();
    }
}
