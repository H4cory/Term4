
public class Game
{
    public static int PLAYER_X = 1;
    public static int PLAYER_O = 2;

    private int curPlayer = PLAYER_X;

    private int[,] board = new int[3, 3];

    public int getCurPlayer()
    {
        return curPlayer;
    }

    public bool play(int x, int y)
    {
        if (x < 0 || x > 3 || y < 0 || y > 3)
        {
            return false;
        }
        else
        {
            if (board[x, y] == 1 || board[x, y] == 2)
            {
                return false;
            }
            else
            {


                board[x, y] = curPlayer;


                //smenq current player
                if (curPlayer == 1)
                {
                    curPlayer = PLAYER_O;
                }
                else
                {
                    curPlayer = PLAYER_X;
                }


                return true;
            }
        }
    }

}

