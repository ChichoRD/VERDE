using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    /// <summary>
    /// Se le pasan dos parametros:
    /// </summary>
    /// <param name="playerPosition">
    /// Posicion del jugador que se toma del WeaponHandler aprovechando que est� attacheado al jugador
    /// </param>
    /// <param name="playerDirection">
    /// Direcci�n del jugador, ya que siempre se usa un objeto en la direcci�n que est� mirando. 
    /// Se saca del PlayerController, ya que pasa a los m�todos AAction y BAction la direcci�n a la que est� apuntado el jugador
    /// </param>
    bool Use(Vector2 playerPosition, Vector2 playerDirection);
    
}
