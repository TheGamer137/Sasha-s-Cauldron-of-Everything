using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum CharacterAbility
{
    Strength,
    Dexterity,
    Constitution,
    Intelligence,
    Wisdom,
    Charisma
}

public class Ability
{
    public int _abilityScore;
    public CharacterAbility _characterAbility;

    public Ability(CharacterAbility characterAbility, int abilityScore)
    {
        this._abilityScore = abilityScore;
        this._characterAbility = characterAbility;
    }
}
[CreateAssetMenu]
public class Character : ScriptableObject
{
    public List<Ability> abilities;

    void Reset()
    {
        abilities = new List<Ability>();
        abilities.Add(new Ability(CharacterAbility.Strength, 10));
        abilities.Add(new Ability(CharacterAbility.Dexterity, 10));
        abilities.Add(new Ability(CharacterAbility.Constitution, 10));
        abilities.Add(new Ability(CharacterAbility.Intelligence, 10));
        abilities.Add(new Ability(CharacterAbility.Wisdom, 10));
        abilities.Add(new Ability(CharacterAbility.Charisma, 10));
        
    }
}
