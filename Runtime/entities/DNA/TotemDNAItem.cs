using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TotemEntities.DNA
{
    public class TotemDNAItem
    {
        public Color primary_color;
        public string classical_element;
        public int damage_nd;
        public int range_nd;
        public int power_nd;
        public int magical_exp;
        public string weapon_material;

        public override string ToString()
        {
            return $"classical_element: {classical_element} | damage_nd: {damage_nd} | range_nd: {range_nd} | power_nd: {power_nd} | " +
                $"magical_exp: {magical_exp} | weapon_material: {weapon_material} | primary_color: {primary_color}";
        }
    }
}
