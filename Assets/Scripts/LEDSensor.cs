﻿/**
 * Copyright (c) 2018 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDSensor : MonoBehaviour, Ros.IRosClient
{
    public enum LEDModeTypes
    {
        None,
        All,
        Blink,
        Fade,
        Right,
        Left
    };
    public LEDModeTypes currentLEDMode = LEDModeTypes.None;

    public enum LEDColorTypes
    {
        White,
        Green,
        Red,
        Blue,
        Orange,
        Rainbow
    }
    public LEDColorTypes currentLEDColor = LEDColorTypes.White;
    private List<Color> ledColors = new List<Color>() { Color.white, Color.green, Color.red, Color.blue, new Color(1f, 0.45f, 0f), Color.white};

    public Color lerpedColor = Color.white;

    public string ledTopicName = "/central_controller/effects";
    public float publishRate = 1f;
    private Ros.Bridge Bridge;
    private bool isEnabled = false;
    private bool isFirstEnabled = true;
    private bool isPublish = false;

    public Renderer ledMatRight;
    public Renderer ledMatLeft;
    public Texture fadeLEDEmitTexture;

    private List<Light> ledLightsRight = new List<Light>();
    private List<Light> ledLightsLeft = new List<Light>();
    
    private float fadeRate = -0.25f;
    private float fadeOffset = 0f;

    private bool isBlinkOn = true;
    private float blinkRate = 0.5f;
    private float currentBlinkTime = 0f;

    private int rainbowIndex = 0;
    private float rainbowRate = 3f;
    private float currentRainbowRate = 0f;

    private void Awake()
    {
        foreach (Transform child in transform)
        {
            if (child.name == "LEDLightL" && child.GetComponent<Light>() != null)
                ledLightsLeft.Add(child.GetComponent<Light>());
            if (child.name == "LEDLightR" && child.GetComponent<Light>() != null)
                ledLightsRight.Add(child.GetComponent<Light>());
        }
        AddUIElement();
    }

    private void Update()
    {
        ApplyLEDMode(currentLEDMode);
    }

    private void ApplyLEDMode(LEDModeTypes mode)
    {
        if (!isEnabled) mode = LEDModeTypes.None;

        if (currentLEDColor == LEDColorTypes.Rainbow)
        {
            lerpedColor = Color.Lerp(lerpedColor, ledColors[rainbowIndex], rainbowRate);
            ledColors[(int)LEDColorTypes.Rainbow] = lerpedColor;
            if (currentRainbowRate < 1)
            {
                currentRainbowRate += Time.deltaTime / rainbowRate;
            }
            else
            {
                currentRainbowRate = 0f;
                rainbowIndex = rainbowIndex < ledColors.Count - 2 ? rainbowIndex + 1 : rainbowIndex = 0;
            }
        }

        switch (mode)
        {
            case LEDModeTypes.None:
                ledMatRight.material.DisableKeyword("_EMISSION");
                ledMatLeft.material.DisableKeyword("_EMISSION");
                foreach (var item in ledLightsRight)
                    item.enabled = false;
                foreach (var item in ledLightsLeft)
                    item.enabled = false;
                break;
            case LEDModeTypes.All:
                ledMatRight.material.EnableKeyword("_EMISSION");
                ledMatLeft.material.EnableKeyword("_EMISSION");
                ledMatRight.material.SetTexture("_EmissionMap", null);
                ledMatLeft.material.SetTexture("_EmissionMap", null);
                ledMatRight.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 1f);
                ledMatLeft.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 1f);
                foreach (var item in ledLightsRight)
                {
                    item.color = ledColors[(int)currentLEDColor];
                    item.enabled = true;
                }
                foreach (var item in ledLightsLeft)
                {
                    item.color = ledColors[(int)currentLEDColor];
                    item.enabled = true;
                }
                break;
            case LEDModeTypes.Blink:
                ledMatRight.material.SetTexture("_EmissionMap", null);
                ledMatLeft.material.SetTexture("_EmissionMap", null);
                if (currentBlinkTime < 1)
                {
                    currentBlinkTime += Time.deltaTime / blinkRate;
                    if (isBlinkOn)
                    {
                        ledMatRight.material.EnableKeyword("_EMISSION");
                        ledMatLeft.material.EnableKeyword("_EMISSION");
                        ledMatRight.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 1f);
                        ledMatLeft.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 1f);
                        foreach (var item in ledLightsRight)
                        {
                            item.color = ledColors[(int)currentLEDColor];
                            item.enabled = true;
                        }
                        foreach (var item in ledLightsLeft)
                        {
                            item.color = ledColors[(int)currentLEDColor];
                            item.enabled = true;
                        }
                    }
                    else
                    {
                        ledMatRight.material.DisableKeyword("_EMISSION");
                        ledMatLeft.material.DisableKeyword("_EMISSION");
                        foreach (var item in ledLightsRight)
                            item.enabled = false;
                        foreach (var item in ledLightsLeft)
                            item.enabled = false;
                    }
                }
                else
                {
                    currentBlinkTime = 0f;
                    isBlinkOn = !isBlinkOn;
                }
                break;
            case LEDModeTypes.Fade:
                fadeOffset = Time.time * fadeRate;
                ledMatRight.material.EnableKeyword("_EMISSION");
                ledMatLeft.material.EnableKeyword("_EMISSION");
                ledMatRight.material.SetTexture("_EmissionMap", fadeLEDEmitTexture);
                ledMatLeft.material.SetTexture("_EmissionMap", fadeLEDEmitTexture);
                ledMatRight.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 2f);
                ledMatLeft.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 2f);
                ledMatRight.material.SetTextureOffset("_MainTex", new Vector2(0, fadeOffset));
                ledMatLeft.material.SetTextureOffset("_MainTex", new Vector2(0, fadeOffset));
                foreach (var item in ledLightsRight)
                {
                    item.color = ledColors[(int)currentLEDColor];
                    item.enabled = true;
                }
                foreach (var item in ledLightsLeft)
                {
                    item.color = ledColors[(int)currentLEDColor];
                    item.enabled = true;
                }
                break;
            case LEDModeTypes.Right:
                currentLEDColor = LEDColorTypes.Orange;
                ledMatRight.material.SetTexture("_EmissionMap", null);
                ledMatLeft.material.DisableKeyword("_EMISSION");
                foreach (var item in ledLightsLeft)
                    item.enabled = false;
                if (currentBlinkTime < 1)
                {
                    currentBlinkTime += Time.deltaTime / blinkRate;
                    if (isBlinkOn)
                    {
                        ledMatRight.material.EnableKeyword("_EMISSION");
                        ledMatRight.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 1f);
                        foreach (var item in ledLightsRight)
                        {
                            item.color = ledColors[(int)currentLEDColor];
                            item.enabled = true;
                        }
                    }
                    else
                    {
                        ledMatRight.material.DisableKeyword("_EMISSION");
                        foreach (var item in ledLightsRight)
                            item.enabled = false;
                    }
                }
                else
                {
                    currentBlinkTime = 0f;
                    isBlinkOn = !isBlinkOn;
                }
                break;
            case LEDModeTypes.Left:
                currentLEDColor = LEDColorTypes.Orange;
                ledMatLeft.material.SetTexture("_EmissionMap", null);
                ledMatRight.material.DisableKeyword("_EMISSION");
                foreach (var item in ledLightsRight)
                    item.enabled = false;
                if (currentBlinkTime < 1)
                {
                    currentBlinkTime += Time.deltaTime / blinkRate;
                    if (isBlinkOn)
                    {
                        ledMatLeft.material.EnableKeyword("_EMISSION");
                        ledMatLeft.material.SetColor("_EmissionColor", ledColors[(int)currentLEDColor] * 1f);
                        foreach (var item in ledLightsLeft)
                        {
                            item.color = ledColors[(int)currentLEDColor];
                            item.enabled = true;
                        }
                    }
                    else
                    {
                        ledMatLeft.material.DisableKeyword("_EMISSION");
                        foreach (var item in ledLightsLeft)
                            item.enabled = false;
                    }
                }
                else
                {
                    currentBlinkTime = 0f;
                    isBlinkOn = !isBlinkOn;
                }
                break;
            default:
                break;
        }
    }

    private Color SetBlinkColor(Color current)
    {


        return Color.white;
    }

    public void Enable(bool enabled)
    {
        isEnabled = enabled;
        if (isEnabled && isFirstEnabled)
        {
            isFirstEnabled = false;
            AgentSetup agentSetup = GetComponentInParent<AgentSetup>();
            if (agentSetup != null && agentSetup.NeedsBridge != null)
            {
                agentSetup.AddToNeedsBridge(this);
            }
        }
    }

    public void OnRosBridgeAvailable(Ros.Bridge bridge)
    {
        Bridge = bridge;
        Bridge.AddPublisher(this);
    }

    public void OnRosConnected()
    {
        Bridge.AddPublisher<Ros.LED>(ledTopicName);
    }

    private void AddUIElement()
    {
        var ledCheckbox = GetComponentInParent<UserInterfaceTweakables>().AddCheckbox("ToggleLED", "Enable LED:", isEnabled);
        ledCheckbox.onValueChanged.AddListener(x => Enable(x));
    }
}