using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using chooseFirstOrSecondForm;


namespace oseroGame
{
    public class mainCLASS
    {
//■■■■■■■■■■■■■■■仕様■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        //このプログラムはhttps://bassy84.net/othello-syosin.htmlを参考に戦法を作っています。
        //全体の60%が埋まるまで、機械は０以外の最も少なくひっくり返す場所に置く。

        //宣言
        public static readonly int x_size = 8;
        public static readonly int y_size = 8;
        public static int FirstOrSecond = 0;
        public static int bannti = 0;
        public static int x = 0;
        public static int y = 0;
        public static string humancolor = "";
        public static string kikaicolor = ""; 
        //shiro=1 kuro=2とする
        public static int now_PLAYER = 0;
        public static int human = 1;
        public static int kikai = 2;
        public static int gameCount = 0;
        public static bool onlyShowFlag = false;


        //boardの正体を作る
        public static string[] boardIdentitiy = new string[x_size * y_size];
        public static readonly string BLANK = " ";

        [STAThread]
        public static void Main() {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new chooseFirstOrSecondForm());

            string[] mainBoard = makeBoard(boardIdentitiy);

            //chooseFirstOrSecondForm chooseForm = new chooseFirstOrSecondForm();
            //chooseForm.Show();
            //chooseForm.Close();
            board_humanForm boardHuman = new board_humanForm();
            board_humanForm refleshHuman = new board_humanForm();
            board_kikaiForm boardKikai = new board_kikaiForm();
            board_kikaiForm refuleshKikai = new board_kikaiForm();
            //メインループ
            while (countBlank()!=0)
            {
                //human
                if (FirstOrSecond == 2 && gameCount == 0) {
                    //
                }
                else
                {
                    boardHuman.ShowDialog();
                    
                    now_PLAYER = chengePlayer(now_PLAYER);
                    //gameCount++;
                    //if (gameCount > 9)
                    //{
                    //    break;
                    //}
                    //再表示
                    boardHuman.ShowDialog();

                    gameCount++;
                }


                //kikai

                 boardKikai.ShowDialog();
                onlyShowFlag = true;
                
                now_PLAYER = chengePlayer(now_PLAYER);
                //gameCount++;
                //if (gameCount > 9)
                //{
                    
                //    break;
                //}
                //再表示
                boardKikai.ShowDialog();
                //modosu
                onlyShowFlag = false;
                gameCount++;

            }
            //
            boardHuman.Close();
            boardKikai.Close();
            //勝敗判定
            showWinner();
        }

        private static string[] makeBoard(string[] someBoard)
        {
            for (int i = 0; i < x_size * y_size; i++)
            {
                someBoard[i] = BLANK;
            }
            someBoard[27] = "SHIRO";
            someBoard[28] = "KURO";
            someBoard[35] = "KURO";
            someBoard[36] = "SHIRO";
            return someBoard;
        }
        public static int chengePlayer(int now_player)
        {
            return now_player == 1 ? 2 : 1;

        }

        public static int countBlank()
        {
            int count = 0;
            for (int i = 0; i < (x_size*y_size); i++)
            {
                if (boardIdentitiy[i] == " ")
                {
                    count++;
                    //return false;
                }
               
            }
            return count;
        }

        
        public static void showWinner()
        {   int ShiroCount = 0;
            int KuroCount = 0;
           
            for (int i = 0;i< x_size* y_size; i++){
                if(boardIdentitiy[i] == "SHIRO"){
                    ShiroCount++;
                }else if(boardIdentitiy[i] == "KURO")
                {
                    KuroCount++;
                }
            }
            
            if (ShiroCount > KuroCount)
            {
                MessageBox.Show(ShiroCount + "対" + KuroCount + "であなたの勝ちです✨");
            }else if (ShiroCount == KuroCount)
            {
                MessageBox.Show(ShiroCount + "対" + KuroCount + "で引き分けです！！");
            }
            else
            {
                MessageBox.Show(ShiroCount + "対" + KuroCount + "であなたの負けです😢");
            }
        }
    }
}

