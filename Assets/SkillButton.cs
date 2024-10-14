using UnityEngine;

public class SkillButton : MonoBehaviour
{
    public string skillName; // Nombre de la habilidad asociada al bot�n
    public SkillFactory skillFactory; // Referencia al SkillFactory
    public Transform playerTransform; // Referencia al transform del jugador

    // M�todo que ser� llamado cuando se haga clic en el bot�n
    public void OnClick()
    {
        // Llamamos al SkillFactory para crear y activar la habilidad
        Skill newSkill = skillFactory.CreateSkill(skillName, playerTransform);
        newSkill?.Activate();
    }
}
