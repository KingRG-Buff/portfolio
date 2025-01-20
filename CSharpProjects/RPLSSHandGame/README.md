# 🎮 Rock, Paper, Scissors, Lizard, Spock

Welcome to **Rock, Paper, Scissors, Lizard, Spock**, a C# implementation of the famous game popularized by *The Big Bang Theory*! This game takes the classic rock-paper-scissors concept and adds a quirky twist with two extra gestures: Lizard and Spock. 

---

## 🕹️ **How to Play**
- The game is played between a **Human Player** and a **Computer Player**.
- Each player selects one of the five shapes:
  - **Rock**
  - **Paper**
  - **Scissors**
  - **Lizard**
  - **Spock**
- The winner is determined by the following rules:
  - Scissors cuts Paper  
  - Paper covers Rock  
  - Rock crushes Lizard  
  - Lizard poisons Spock  
  - Spock smashes Scissors  
  - Scissors decapitates Lizard  
  - Lizard eats Paper  
  - Paper disproves Spock  
  - Spock vaporizes Rock  
  - Rock crushes Scissors  

If both players choose the same shape, the round ends in a tie.

---

## ⚙️ **Features**
- **Interactive Gameplay**: The human player selects a shape using console input.  
- **Randomized Computer Moves**: The computer generates a random shape for each round.  
- **Point System**: 
  - Gain 5 points for a win.  
  - Lose 5 points for a defeat.  
  - No change for a tie.  
- **Game Over Conditions**: The game ends if:
  - The player has 0 points (after at least 3 rounds).  
  - The player chooses to exit.  
- **Replay Option**: Players can choose to continue or exit after each round.

---

## 🏗️ **Implementation Details**
### **HumanPlayer Class**
- Tracks the human player’s points.
- Provides methods to:
  - Retrieve current points.
  - Adjust points based on game outcomes.
  - Accept shape input from the player.

### **ComputerPlayer Class**
- Randomly selects a shape for the computer.
- Uses a random number generator to assign one of the five gestures.

### **RockPaperScissorsLizardSpock Class**
- Manages the main game loop.
- Creates instances of `HumanPlayer` and `ComputerPlayer`.
- Handles game logic, including:
  - Comparing shapes to determine the winner.
  - Updating player points.
  - Displaying the current game state.
  - Offering the replay or exit option.

---

## 📋 **Sample Output**
```text
***Rock, Paper, Scissors, Lizard, Spock, Let’s play!***
You have 5 points.
Please input your choice: Rock, Paper, Scissors, Lizard or Spock
Spock
--> You shoot: Spock
--> Computer shoots: Rock
You Win!	
--> Play again? Input Y to continue, or N to exit.
```

---

## 💻 **Technologies Used**
- **C#**: Core language for implementation.
- **.NET Console Application**: For interactive gameplay.

---

## ✨ **Future Enhancements**
- Add a graphical user interface (GUI) for improved user experience.
- Allow multiplayer mode for local or online play.
- Implement additional difficulty levels for the computer player.

---

## 📧 **Contact**
For questions or feedback, feel free to reach out:  
📧 [rgarcia.pm@icloud.com](mailto:rgarcia.pm@icloud.com)  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/rg-garcia)

