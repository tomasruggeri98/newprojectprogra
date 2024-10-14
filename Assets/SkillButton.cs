using UnityEngine;

public class SkillButton : MonoBehaviour
{
    public string skillName; // Nombre de la habilidad asociada al botón
    public SkillFactory skillFactory; // Referencia al SkillFactory
    public Transform playerTransform; // Referencia al transform del jugador

    // Método que será llamado cuando se haga clic en el botón
    public void OnClick()
    {
        // Llamamos al SkillFactory para crear y activar la habilidad
        Skill newSkill = skillFactory.CreateSkill(skillName, playerTransform);
        newSkill?.Activate();
    }
}
