#include <stdio.h>

void display_board(char board[3][3])
{
  for(int i = 0; i < 3; i++)
  {
      for(int j = 0; j < 3; j++)
      {
          printf("%c ", board[i][j]);
      }
      printf("\n");
  }
}

void player_turn(char board[3][3], char player)
{
  int position;
  printf("Player %c, enter a position (1-9): ", player);
  scanf("%d", &position);
  int row = (position - 1) / 3;
  int col = (position - 1) % 3;
  if(board[row][col] == 'X' || board[row][col] == 'O')
  {
      printf("Position already taken. Please try again.\n");
      player_turn(board, player);
  }
  else{ board[row][col] = player;}
}

char check_board_for_winner(char board[3][3])
{
  // Check rows
  for(int i = 0; i < 3; i++)
  {
      if(board[i][0] == board[i][1] && board[i][0] == board[i][2] && ( board[i][0] == 'X' || board[i][0] == 'O' ) ) { return board[i][0];}
  }
  // Check columns
  for(int i = 0; i < 3; i++)
  {
      if(board[0][i] == board[1][i] && board[0][i] == board[2][i] && ( board[0][i] == 'X' || board[0][i] == 'O' )) { return board[0][i];}
  }
  // Check diagonals
  if(board[0][0] == board[1][1] && board[0][0] == board[2][2] && ( board[0][0] == 'X' || board[0][0] == 'O' )) { return board[0][0];}
  if(board[0][2] == board[1][1] && board[0][2] == board[2][0] && ( board[0][2] == 'X' || board[0][2] == 'O' )) { return board[0][2];}

  // Check for a draw
   if ( (board[0][0] == 'X' || board[0][0]== 'O' ) &&  (board[0][1] == 'X' || board[0][1]== 'O' ) && (board[0][2] == 'X' || board[0][2]== 'O' )
            && (board[1][0] == 'X' || board[1][0]== 'O' ) && (board[1][1] == 'X' || board[1][1]== 'O' ) && (board[1][2] == 'X' || board[1][2]== 'O' )
            && (board[2][0] == 'X' || board[2][0]== 'O' ) && (board[2][1] == 'X' || board[2][1]== 'O' ) && (board[2][2] == 'X' || board[2][2]== 'O' ) )
   {return 'd';}
}

void reset_board(char board[3][3]) {

  board[0][0]='1';    board[0][1]='2';    board[0][2]='3';
  board[1][0]='4';    board[1][1]='5';    board[1][2]='6';
  board[2][0]='7';    board[2][1]='8';    board[2][2]='9';
}

int main()
{
  char board[3][3] = { {'1', '2', '3'}, {'4', '5', '6'}, {'7', '8', '9'} };
  char player = 'X';

    while(1)
    {
        display_board(board);
        player_turn(board, player);
        char winner = check_board_for_winner(board);
        if(winner == player) {   printf("Player %c wins!\n", winner);  display_board(board);   break;}
        player = (player == 'X') ? 'O' : 'X';

        if ( winner == 'd')
        {
            printf("-------- draw --------\n");
            reset_board(board);
        }

    }

  return 0;
}
