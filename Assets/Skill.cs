using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    public abstract string skillName { get; }
    public abstract void Activate();
}
