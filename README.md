# Trying out Unity
- **Unity Hub**: 3.4.1
- **Editor**: 2021.3.16f1 LTS

## Setup for new Unity projects
Run `wget https://raw.githubusercontent.com/github/gitignore/main/Unity.gitignore -O .gitignore` at the root of the Unity project directory to ignore auto-generated files.

## Todo list
- **Player**
    - [X] Move
    - [X] Jump
    - [ ] Health
    - [ ] Damage
    - [ ] Shoot
    - [ ] Points
- **Camera**
    - [X] Follow Player
- **Obstacle / Enemy**
    - [ ] Move
    - [ ] Health
    - [ ] Damage
- **World**
    - [ ] New Scene
    - [ ] Win Condition
    - [ ] Menu

## Cheat-Sheet
### miscellaneous
- Prefab:
    - Drag and Drop and Object to create a File linked to all its instaces.
- [KeyCodes](https://docs.unity3d.com/2022.2/Documentation/ScriptReference/KeyCode.html)

### Physics Settings
- [Rigit Body 2D](https://docs.unity3d.com/2022.2/Documentation/ScriptReference/KeyCode.html)
    - Body Type: Dynamic / Static
    - Collision Detection: Continue
- [Box Collider 2D](https://docs.unity3d.com/2022.2/Documentation/ScriptReference/BoxCollider2D.html)
    - Is Trgger: Does not collide
- [Max Speed Atricle](https://forum.unity.com/threads/add-force-with-limits.631552/)

### Audio Settings
- Audio Source
    - Play on Awake

## Git commands

```bash
# Clone project
git clone <url> <carpeta>

# Add all chamges
git add .

# Stage changes to commit
git commit -m "mensaje"

# Save changes in main branch
git push origin main
```
