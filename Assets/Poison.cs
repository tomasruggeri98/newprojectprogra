using System.Collections;
using UnityEngine;

public class Poison : Skill
{
    public override string skillName => "Poison";

    public GameObject poisonVFX;
    public float duration = 5.0f; // Duración de la habilidad

    public override void Activate()
    {
        Debug.Log("Lógica de la habilidad Poison");

        // Iniciar la corutina para activar y desactivar el efecto visual
        StartCoroutine(ActivatePoison());
    }

    private IEnumerator ActivatePoison()
    {
        // Instanciar el efecto visual
        GameObject vfxInstance = Instantiate(poisonVFX, transform.position, Quaternion.identity);

        // Esperar la duración establecida
        yield return new WaitForSeconds(duration);

        // Destruir el efecto visual después del tiempo
        Destroy(vfxInstance);
    }
}
