# Quantron

A 3D ball-rolling game prototype built in Unity.

## About
A small game with multiple levels where the player controls a rolling ball through procedurally arranged obstacles. Built 2022-01.

## Features
- Multiple scenes/levels (`SampleScene 1-4`, `startScene`, `Main`)
- Ball prefabs with distinct materials (blue, red)
- Level generator scripts
- Background music per scene

## Tech stack
- Unity 3D, C#

## Architecture
```
Assets/
  Scenes/       game scenes/levels
  scripts/      gameplay logic (ball control, level generation)
  prefabs/      ball prefabs
  materials/    surface materials
  musics/       background tracks
```

## Getting started
Open the project folder with Unity Hub (matching the Unity version in `ProjectSettings`) and load a scene from `Assets/Scenes`.

## Status
Archived prototype, not maintained.
