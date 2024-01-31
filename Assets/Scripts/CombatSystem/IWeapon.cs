using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    /// <summary>
    /// Se le pasan dos parametros:
    /// </summary>
    /// <param name="playerPosition">
    /// Posicion del jugador que se toma del WeaponHandler aprovechando que está attacheado al jugador
    /// </param>
    /// <param name="playerDirection">
    /// Dirección del jugador, ya que siempre se usa un objeto en la dirección que está mirando. 
    /// Se saca del PlayerController, ya que pasa a los métodos AAction y BAction la dirección a la que está apuntado el jugador
    /// </param>
    bool Use(Vector2 playerPosition, Vector2 playerDirection);
    
}
