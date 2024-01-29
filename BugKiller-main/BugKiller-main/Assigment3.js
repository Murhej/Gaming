
// JavaScript code for game logic and interactions

// Game variables
let score = 0;
let intervalId;
let bugInterval = 1000; // Initial bug hopping interval in milliseconds

// DOM elements
const gameField = document.querySelector('.Game');
const scoreElement = document.getElementById('scoreValue');
const startStopButton = document.getElementById('start-stop');
const resetSpeedButton = document.getElementById('reset-speed');
const resetScoreButton = document.getElementById('reset-score');

// Function to start or stop the game
function startStopGame() {
    if (intervalId) {
        clearInterval(intervalId);
        intervalId = null;
        startStopButton.textContent = 'Start';
    } else {
        intervalId = setInterval(moveBug, bugInterval);
        startStopButton.textContent = 'Stop';
    }
}

// Function to move the bug randomly
function moveBug() {
    const gameFieldRect = gameField.getBoundingClientRect();
    const bug = document.createElement('div');
    bug.className = 'bug';
    bug.style.top = Math.random() * (gameFieldRect.height - 20) + 'px';
    bug.style.left = Math.random() * (gameFieldRect.width - 20) + 'px';
    bug.addEventListener('click', catchBug);
    gameField.appendChild(bug);

    setTimeout(() => {
        bug.remove();
    }, bugInterval - 10); // Hide the bug slightly before the next one appears
}

// Function to catch the bug
function catchBug() {
    score++;
    scoreElement.textContent = score;
    this.remove();
    bugInterval -= 10; // Decrease the bug hopping interval by 100 milliseconds
    clearInterval(intervalId);
    intervalId = setInterval(moveBug, bugInterval);
}

// Function to reset the bug hopping speed to the initial value
function resetSpeed() {
    clearInterval(intervalId);
    bugInterval = 1000;
    intervalId = setInterval(moveBug, bugInterval);
}

// Function to reset the score
function resetScore() {
    score = 0;
    scoreElement.textContent = score;
}

// Event listeners
startStopButton.addEventListener('click', startStopGame);
resetSpeedButton.addEventListener('click', resetSpeed);
resetScoreButton.addEventListener('click', resetScore);
