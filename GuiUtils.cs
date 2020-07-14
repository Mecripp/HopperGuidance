﻿using System;
using System.Text.RegularExpressions;
using UnityEngine;

namespace HopperGuidance
{
    static public class GuiUtils
    {
        public static bool GetMouseHit(CelestialBody body, out RaycastHit hit)
        {
          // Cast a ray from screen point
          Ray ray = FlightCamera.fetch.mainCamera.ScreenPointToRay(Input.mousePosition);
          bool isHit = Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity, 1 << 15);
          return isHit;
        }
    }
}
