using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Enemy", menuName ="ScriptableObjects/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    /*-------- Game Logic Attributes --------*/

    // Unique ID for each enemy.
    public int ID;
    // Name of the Enemy.
    public string Name;
    // Base max health point of each "Enemy" unit. Unit dies after "HealthPoint" reaches value '0'. Scales with "WaveNumber".
    public int BaseHealtPoint;
    // Base damage of each "Enemy" unit. If unit reaches "Goal", the "HealthPoint" of "Goal" reduces by it's "Damage". Scales with "WaveNumber".
    public int BaseDamage;
    // Movement speed of each "Enemy" unit. The "Speed" shows how fast each unit can move.
    public float MovementSpeed;
    //public int BaseArmor;

}
