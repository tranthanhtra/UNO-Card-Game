This project is still in its very early stage
### Game Design
Classic UNO Game App Design Document
1. Overview: The Classic UNO Game App is a digital adaptation of the popular card game UNO, allowing players to enjoy multiplayer and solo modes with smooth animations, intuitive UI, and fun gameplay mechanics. The app will be available on iOS, Android, and PC.
2. Game Modes:
Single Player: Play against AI with different difficulty levels.
Multiplayer Online: Join or create lobbies to play with friends or random players.
Local Multiplayer: Connect via Bluetooth or local WiFi to play with nearby friends.
Tournament Mode: Participate in ranked matches for seasonal rewards.
Custom Rules Mode: Create custom games with house rules.
3. Core Features:
User-friendly Interface: Simple drag-and-drop mechanics for playing cards.
Real-time Multiplayer: Smooth networking for seamless online play.
Chat & Emojis: In-game chat and emoji reactions for player interactions.
Leaderboards & Achievements: Track progress, rank, and unlock rewards.
Daily Challenges & Rewards: Players earn in-game currency and bonuses.
Avatars & Customization: Personalize profile with avatars and card backs.
AI Opponents: Smart AI for offline play.
Cross-Platform Play: Play across different devices with cloud save.
4. Game Mechanics:
Deck: Standard 108-card UNO deck (numbered cards, action cards, wild cards).
Turn-based Gameplay: Players take turns in a clockwise direction.
Action Cards: Reverse, Skip, Draw Two, Wild, and Wild Draw Four.
Winning Condition: First to reach 500 points or a predefined number of rounds.
House Rules Options: Stackable cards, Jump-In, No Bluffing, etc.
5. UNO Rules:
Each player starts with seven cards.
Players must match the top card of the discard pile by color or number.
Action cards introduce special effects such as skipping turns, reversing order, or forcing opponents to draw additional cards.
A Wild card allows the player to change the active color.
A Wild Draw Four card forces the next player to draw four cards and allows the player to choose a new color; however, it can only be played if no other valid moves are available.
If a player cannot play a card, they must draw from the deck. Drawned card can be played.
The first player to play all their cards wins the round, and points are awarded based on remaining cards in opponents' hands.
Players must say "UNO" when they have only one card left; failure to do so before another player catches them results in drawing two penalty cards.
6. Monetization Strategy:
In-App Purchases: Custom card backs, avatars, and themes.
Ad-Supported Model: Rewarded ads for in-game currency and free retries.
Seasonal Pass: Exclusive rewards and challenges.
Premium Version: Ad-free experience with exclusive perks.
7. UI/UX Design:
Home Screen: Quick Play, Multiplayer, Store, Settings.
Game Table UI: Card display, turn indicator, chat, and power-ups.
Settings: Audio, graphics, notifications, account settings.
8. Technology Stack:
Game Engine: Unity or Unreal Engine.
Networking: Photon Realtime or Firebase for multiplayer.
Database: Firebase Firestore or AWS DynamoDB for storing player data.
Authentication: Google, Facebook, and Email login options.
9. Development Timeline:
Phase 1: Planning & Prototyping (1 month)
Phase 2: Core Game Development (3 months)
Phase 3: Multiplayer & UI Integration (2 months)
Phase 4: Testing & Beta Release (1 month)
Phase 5: Launch & Post-launch Updates
10. Future Enhancements:
New Game Modes: UNO Flip, 2v2 mode, special event challenges.
Social Features: Friends list, voice chat, and global tournaments.
AI Improvements: Smarter difficulty scaling.
This game design document ensures a structured approach to building an engaging and polished UNO app for players worldwide.

### Card Shader
For better performance and easy management of the card prefab. I choose to use Sprite Renderer as the card base.

Since the ultimate goal is to make the game 3D, I want the cards to be 3D, aka both sides are rendered with the correct art. This is when the CardShader comes in, make it possible by using Branch node (as following this tut). I also decided to put as many elements in the shader as possible.

Then it comes to the effect icons and numbers of the cards which are children of the sprite renderer as sprite renderers and text meshes. These SR and TM are visible on both sides when rotating the card. So I use Cull in shader to help with this issue. These child SR and TM have materials generated from the shader that have Cull Off or Cull Back so that they only render on the front 
