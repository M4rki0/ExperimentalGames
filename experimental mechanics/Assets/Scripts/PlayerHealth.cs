using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    public override void Damage(int damage)
    {
        health -= damage;
        CheckForDeath();
    }
}
