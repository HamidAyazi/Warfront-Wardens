using System;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public event EventHandler OnGoalDied;

    public void Damage(int DamageReceived)
    {
        GameStats.HealthPoint -= DamageReceived;
        if (GameStats.HealthPoint == 0)
        {
            OnGoalDied?.Invoke(this, EventArgs.Empty);
        }
    }
}