import tkinter as tk
from tkinter import ttk, messagebox
import matplotlib.pyplot as plt
import numpy as np

numQueens = 8  # Default number of queens


def solveNQueensBitmask(numQueens):
    solutions = []

    # The DFS algorithm to find all solutions
    def dfs(testRow, columns, diagonals1, diagonals2, currentSolution):
        if testRow == numQueens:
            solutions.append(currentSolution[:])
            return

        available_positions = (~(columns | diagonals1 | diagonals2)) & (
            (1 << numQueens) - 1)

        while available_positions:
            position = available_positions & -available_positions
            available_positions -= position
            col = bin(position - 1).count('1')
            currentSolution.append(col)
            dfs(testRow + 1,
                columns | position,
                (diagonals1 | position) << 1,
                (diagonals2 | position) >> 1,
                currentSolution)
            currentSolution.pop()

    dfs(0, 0, 0, 0, [])
    return solutions


def showSolutionByIndex(solutions, index):
    if 0 <= index < len(solutions):
        displaySolutionMatplotlib(solutions[index])
    else:
        messagebox.showerror("Invalid Solution",
                             "The selected solution index is out of range.")


def showSolutions():
    global numQueens
    solutions = solveNQueensBitmask(numQueens)
    if solutions:
        solutionWindow = tk.Toplevel(root)
        solutionWindow.title("Select a Solution")

        tk.Label(solutionWindow,
                 text=f"{len(solutions)} solutions found! Select one to display:").pack(pady=10)

        solutionList = tk.Listbox(
            solutionWindow, height=10, selectmode=tk.SINGLE)
        for i, solution in enumerate(solutions):
            solutionList.insert(tk.END, f"Solution {i + 1}: {solution}")
        solutionList.pack(pady=10)

        def onDisplaySolution():
            selected = solutionList.curselection()
            if selected:
                showSolutionByIndex(solutions, selected[0])
            else:
                messagebox.showerror(
                    "No Selection", "Please select a solution to display.")

        displayButton = tk.Button(
            solutionWindow, text="Display Solution", command=onDisplaySolution)
        displayButton.pack(pady=10)

    else:
        messagebox.showerror("No Solutions", "No solutions found.")


def displaySolutionMatplotlib(solution):
    board = np.zeros((numQueens, numQueens))
    for row in range(numQueens):
        board[row, solution[row]] = 1

    _, ax = plt.subplots()

    # Create a chessboard pattern for the grid
    chessboard = np.zeros((numQueens, numQueens))
    for i in range(numQueens):
        for j in range(numQueens):
            chessboard[i, j] = (i + j) % 2

    ax.matshow(chessboard, cmap="binary")

    # Add row and column labels
    ax.set_xticks(range(numQueens))
    ax.set_yticks(range(numQueens))
    ax.set_xticklabels([str(i) for i in range(numQueens)])
    ax.set_yticklabels([str(i) for i in range(numQueens)])

    for i in range(numQueens):
        for j in range(numQueens):
            if board[i, j] == 1:
                ax.text(j, i, "♛", va='center', ha='center',
                        fontsize=20, color="red")

    ax.set_xlim(-0.5, numQueens - 0.5)
    ax.set_ylim(-0.5, numQueens - 0.5)
    plt.gca().invert_yaxis()
    plt.show()


def setNumQueens(value):
    global numQueens
    numQueens = int(value)


# Create the main application window
root = tk.Tk()
root.title("N-Queens Solver")

# Top control panel
controlPanel = tk.Frame(root)
controlPanel.pack(pady=10)

# Number of queens selector
queenLabel = tk.Label(controlPanel, text="Number of Queens:")
queenLabel.grid(row=0, column=0, padx=5)
queenSelector = ttk.Combobox(
    controlPanel, values=list(range(4, 15)), state="readonly")
queenSelector.set(numQueens)
queenSelector.grid(row=0, column=1, padx=5)
queenSelector.bind("<<ComboboxSelected>>",
                   lambda e: setNumQueens(queenSelector.get()))

# Solve button
solveButton = tk.Button(controlPanel, text="Solve", command=showSolutions)
solveButton.grid(row=0, column=2, padx=5)

# Run the application
root.mainloop()
