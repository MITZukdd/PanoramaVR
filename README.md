# VR-OP-Saal

**VR-OP-Saal** ist ein OpenXR Virtual-Reality-Projekt, das einen Operationssaal simuliert. Medizinstudierende und Auszubildende medizinischer Fachberufe können dadurch barrierearm eine informative Einführung in den OP-Saal erhalten.

## Features

* Realistische VR-Darstellung eines Operationssaals
* Kennenlernen des Einschleusens
* Entwickelt für Meta Quest 3 und Pico Neo 3 Pro, aber sollte auch mit anderen OpenXR kompatiblen Headsets kompatibel sein.

## Systemvoraussetzungen

* Unity 2022.3 oder höher [Unity - Manual: System requirements for Unity 2022.3](https://docs.unity3d.com/2022.3/Documentation/Manual/system-requirements.html)
* Windows 10/11
* git lfs [git-lfs: Git extension for versioning large files](https://github.com/git-lfs/git-lfs?utm_source=gitlfs_site&utm_medium=repo_link&utm_campaign=gitlfs)

## Installation

1. Repository klonen: `git clone https://github.com/MITZukdd/VR-OP-Saal.git`
2. Ordner als Unity-Projekt von disk öffnen
3. Build-Einstellungen auf Android Platform switchen
4. Szene `VR-OP` laden

## Projektstruktur

* `Assets/Scenes/` – Enthält die VR-OP Szene
* `Assets/UI/` – UI Panels, Fonts, Logos, Buttons
* `Assets/Scripts/` – C#-Skripte
* `Assets/Media/` – Sprites,  Panoramabilder, Videos, Material+Shader für die Ansichten

## Mehr Materialien

Mehr Informationen zum Projekt sowie fertige Builds für die Meta Quest 3 und die Pico Neo 3 Pro findet ihr auf \[Twillo]()

## Lizenz

Das Github Repository "VR-OP-Saal" ist lizensiert unter CC BY SA 4.0 (https://creativecommons.org/licenses/by-sa/4.0/). Details siehe `LICENSE` Datei.

## Lizenzen weiterer Tools

Für die Entwicklung in Unity wurden verschiedene Tools verwendet. Zusätzlich enthält dieses Projekt Code, der aus einem fremden Repository stammt:

* **Unity-UI-Rounded-Corners**
  [Unity-UI-Rounded-Corners](https://github.com/CelinaStransky/Unity-UI-Rounded-Corners) Fork von Celina Stransky,
  [Originalprojekt von Kirill Evdokimov](https://github.com/kirevdokimov/Unity-UI-Rounded-Corners) lizensiert unter MIT Lizenz
* **Page Slider**
  [Page Slider](https://assetstore.unity.com/packages/tools/gui/page-slider-241341) von Tomaz Saraiva über den Unity Asset Store zur Verfügung gestellt. Keine Lizenz
