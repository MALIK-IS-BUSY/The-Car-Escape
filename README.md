# 🚘 The Car Escape - 3D Horror Game in Unity

**The Car Escape** is a spine-chilling 3D horror experience built in Unity, where the player must survive a haunted environment using only a torchlight and their wits. Roam through a terrifying map, complete atmospheric tasks, avoid unseen dangers, and make your way to the only way out — the car.

---

## 🕹️ Gameplay Overview

You are trapped in a cursed, eerie landscape with nothing but a flickering torchlight to guide your way. Strange noises echo through the foggy woods. Shadows move. The only goal: **find the car and escape the map before it’s too late**.

### 🌌 Core Features

- 🎮 **Third- & First-Person View:** Switch between cinematic third-person and immersive first-person camera perspectives.
- 🔦 **Dynamic Torchlight System:** A realistic torch that lights the way, casting shadows and revealing chilling details in the darkness.
- 🧭 **Task-Based Exploration:** Trigger scripted events and eerie encounters as you complete tasks hidden throughout the haunted environment.
- 👻 **Haunted Map Design:** Carefully crafted horror environment using fog, lighting, and sound design to keep players on edge.
- 🎬 **Smooth Animations:** Realistic character movements and scene animations driven by Unity's Animator and Animation systems.
- 🏃‍♂️ **Escape Mechanic:** Reach the car hidden somewhere in the vast, terrifying terrain — and make your escape... if you can.

---

## 🔧 Built With

- **Unity Engine** (2022 or newer)
- **C# Scripts** for player movement, triggers, camera switching, and torchlight handling
- **Unity Animator & Animation System** for smooth character motion
- **Audio Mixers & Triggers** for ambient horror soundscapes
- **Custom 3D Assets** and Unity’s Standard Asset Packs

---

## 🧠 Key Mechanics & Technical Details

### 🎥 Camera System

- Toggle between **third-person** and **first-person** views using script-controlled input.
- Uses Cinemachine or manually coded cameras for smooth transitions.

### 🔦 Torchlight Logic

- Torch follows player view and lights the surroundings dynamically.
- Works using Unity's **Light** component and controlled by script (on/off, battery drain optional).

### 🎭 Animation System

- Unity Animator handles movement transitions, idle, walk, run, and scripted event animations.
- Trigger-based animations for specific haunted events (e.g., objects moving, ghostly figures appearing).

### 🧩 Task System

- Players must complete certain **mini-objectives** (e.g., unlock a door, find a key, follow a sound) to progress.
- All tasks contribute to guiding the player toward the final car location.

### 🚗 Escape Mechanism

- Car acts as the final escape point.
- On trigger entry (collision or area detection), ending animation or scene change is initiated.

---

## 🎮 How to Play

1. **Start** the game — you're dropped into a dark and foggy haunted world.
2. **Use WASD** to move, **Mouse** to look around.
3. **Explore** carefully with your torchlight (Right Click or assigned key).
4. **Complete tasks** and uncover hidden paths and clues.
5. **Find the car** and drive away to escape the horror — but beware, you're not alone.

---

## 📂 Project Structure

```plaintext
Assets/
│
├── Animations/            # All character and scene animations
├── Audio/                 # Ambient sounds, jump scares, torch flickers
├── Materials/             # Textures and shaders
├── Models/                # 3D models of map, car, environment
├── Prefabs/               # Reusable objects like torch, triggers, player
├── Scenes/                # Main game scene(s)
├── Scripts/               # C# scripts (Player, Torch, Tasks, Camera, UI)
└── UI/                    # Menus, text, interaction hints
