# Smart Store Organizer

A Unity3D game about organizing store products efficiently against time.

## Scenes
- **Shelf Scene**: (Main Scene), Organize shelf products
- **Cooler Scene**: Organize cooler products

## Project Design File
https://www.figma.com/design/0OUusEH9ngIvXprnnxx0iA/SmartStoreOrganizer

## APK File included in releases section

## How to Run 
- Clone the repo
- Use Unity 6.0.58f1 LTS Version

## How Drag/Drop Works
- Click and hold a product to drag.
- Product movement is limited to the camera view.
- Drop a product onto a target placeholder to place it.
- If dropped on the floor, the product returns to its initial position.

## Gameplay
- Drag and drop products to correct positions
- Beat the 30-second timer
- Products return to start if dropped incorrectly
- Each level requires specific product category placement

## Code Structure Overview
- `GameManager`: Controls game flow and state.
- `LevelSelector`: Handles level selection and scene loading.
- `ProductsManager`: Randomizes and spawns products for each level.
- `ProductItem` & `DraggableItem`: Implements drag-and-drop logic.
- `ProductsTarget`: Handles product placement and collision detection.
- `CountdownTimer`: Manages the game timer and triggers end events.
- `AudioManager`: Plays sound effects.
- `LanguageSelector`, `SettingsPanel`, `SettingsManager`: Manage language and settings.

## Assets Used
- [Low Poly Metal Rack | 3D Furniture | Unity Asset Store]
  (https://assetstore.unity.com/packages/3d/props/furniture/low-poly-metal-rack-213045)
- [Cooler Fridge | 3D Electronics | Unity Asset Store]
  (https://assetstore.unity.com/packages/3d/props/electronics/cooler-fridge-269101)
- [LeanTween | Animation Tools | Unity Asset Store]
   (https://assetstore.unity.com/packages/tools/animation/leantween-3595)
- [Pandazole - Kitchen Food low poly pack | 3D Food | Unity Asset Store]
  (https://assetstore.unity.com/packages/3d/props/food/pandazole-kitchen-food-low-poly-pack-204525)
- Sound Effects generated with ElevenLabs
  https://elevenlabs.io/sound-effects
- [Office Pack - Free | 3D Interior | Unity Asset Store]
  (https://assetstore.unity.com/packages/3d/props/interior/office-pack-free-258600)

### Data Management
The project uses ScriptableObjects for flexible product data management:
- `ProductData`: ScriptableObject storing individual product properties
- `ProductsDatabase`: ScriptableObject container for all products

## Other Features
- Async scene loading.
- Sound effects for button clicks.
- Persistent objects for cross-scene data.
- LeanTween for smooth UI and object animations.
