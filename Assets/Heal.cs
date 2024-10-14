using System.Collections;
using UnityEngine;

public class Heal : Skill
{
    public override string skillName => "Heal";

    // Variable para almacenar el prefab del efecto visual
    public GameObject healVFX;

    // Duraci�n de la habilidad (en segundos)
    public float duration = 3.0f;

    public override void Activate()
    {
        Debug.Log("L�gica de la habilidad Heal");

        // Iniciar la corutina para activar y desactivar el efecto visual despu�s de un tiempo
        StartCoroutine(ActivateHeal());
    }

    private IEnumerator ActivateHeal()
    {
        // Instanciar el efecto visual en la posici�n del jugador
        GameObject vfxInstance = Instantiate(healVFX, transform.position, Quaternion.identity);

        // Esperar la duraci�n establecida
        yield return new WaitForSeconds(duration);

        // Destruir el efecto visual despu�s de que la habilidad termine
        Destroy(vfxInstance);
    }
}
