Welcome to the DTS Code Dojo. 

Your first task is to navigate through a maze and reach the finish point without touching any walls. 
Doing so will kill you instantly!

You will be given a 2D array of a maze and an array of directions to help you navigate through it. Your task is to follow the directions given. 

If you reach the end point before all your moves have gone, you should return "Finish". 
If you hit any walls or go outside the maze border, you should return "Dead". 
If you find yourself still in the maze after using all the moves, you should return "Lost".

An example of a maze array could look like:
maze = [[1,1,1,1,1,1,1],
        [1,0,0,0,0,0,3],
        [1,0,1,0,1,0,1],
        [0,0,1,0,0,0,1],
        [1,0,1,0,1,0,1],
        [1,0,0,0,0,0,1],
        [1,2,1,0,1,0,1]]

..with the following key:

      0 = Safe place to walk
      1 = Wall
      2 = Start Point
      3 = Finish Point

An example of directions would be:
direction = ["N","N","N","N","N","E","E","E","E","E"]

Rules recap:
1. The Maze array will always be square i.e. N x N but its size and content can change.
2. The start and finish positions can change.
3. The directions array will always be in upper case and will be in the format of N = North, E = East, W = West and S = South.
4. If you reach the end point before all your moves have gone, you should return Finish.
5. If you hit any walls or go outside the maze border, you should return Dead.
6. If you find yourself still in the maze after using all the moves, you should return Lost.

Good luck!!!



