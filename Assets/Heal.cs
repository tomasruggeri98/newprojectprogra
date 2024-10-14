using System.Collections;
using UnityEngine;

public class Heal : Skill
{
    public override string skillName => "Heal";

    // Variable para almacenar el prefab del efecto visual
    public GameObject healVFX;

    // Duración de la habilidad (en segundos)
    public float duration = 3.0f;

    public override void Activate()
    {
        Debug.Log("Lógica de la habilidad Heal");

        // Iniciar la corutina para activar y desactivar el efecto visual después de un tiempo
        StartCoroutine(ActivateHeal());
    }

    private IEnumerator ActivateHeal()
    {
        // Instanciar el efecto visual en la posición del jugador
        GameObject vfxInstance = Instantiate(healVFX, transform.position, Quaternion.identity);

        // Esperar la duración establecida
        yield return new WaitForSeconds(duration);

        // Destruir el efecto visual después de que la habilidad termine
        Destroy(vfxInstance);
    }
}
